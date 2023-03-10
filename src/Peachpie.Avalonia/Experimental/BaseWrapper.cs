using System;
using System.Reflection;
using Pchp.Core;

namespace Peachpie.Avalonia.Experimental;

public class BaseWrapper<T> where T : new()
{
    internal PhpArray __peach__runtimeFields;
    
    public T GetWrappedObject()
    {
        return _wrappedObject;
    }
    
    public PhpValue __get(PhpValue propertyName)
    {
        return _getProperty(propertyName);
    }

    public void __set(PhpValue propertyName, PhpValue value)
    {
        _setProperty(propertyName, value);
    }
    
    /**
     * Searches for the public property with the specified name.
     */
    private PropertyInfo GetWrappedProperty(PhpValue propertyName)
    {
        return _wrappedObject.GetType().GetProperty(propertyName.ToString());
    }

    private PhpValue _getProperty(PhpValue propertyName)
    {
        var property = GetWrappedProperty(propertyName);
        if (property != null)
        {
            return PhpValue.FromClr(property.GetValue(_wrappedObject));
        }

        throw new ArgumentException(
            $"Property '{propertyName}' not found on object of type 'Ux{_wrappedObject.GetType().Name}'");
    }

    private void _setProperty(PhpValue propertyName, PhpValue value)
    {
        var property = GetWrappedProperty(propertyName);
        if (property != null)
        {
            property.SetValue(_wrappedObject, value.ToClr());
        }
        else
        {
            throw new ArgumentException(
                $"Property '{propertyName}' not found on object of type 'Ux{_wrappedObject.GetType().Name}'");
        }
    }
    
    public void On(PhpValue eventName, Closure callback)
    {
        var eventInfo = GetWrappedObject().GetType().GetEvent(eventName.ToString());
        if (eventInfo != null)
        {
            eventInfo.AddEventHandler(GetWrappedObject(),
                CreateDelegate(eventInfo.EventHandlerType,
                    (_, e) => { callback.call(null, PhpValue.FromClass(this), PhpValue.FromClass(e)); }));
        }
        else
        {
            throw new ArgumentException(
                $"Event '{eventName}' not found on object of type '{GetWrappedObject().GetType().Name}'");
        }
    }
    
    static private Delegate CreateDelegate(Type type, EventHandler handler)
    {
        return (Delegate) type.GetConstructor(new[] {typeof(object), typeof(IntPtr)})
            ?.Invoke(new[] {handler.Target, handler.Method.MethodHandle.GetFunctionPointer()});
    }

    private readonly T _wrappedObject = new();
}
    
