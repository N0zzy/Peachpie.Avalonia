using System;
using System.Reflection;
using Pchp.Core;

namespace Peachpie.Avalonia.Experimental;

/// <summary>
/// Wraps a CLR object in a PHP object.
/// </summary>
/// <typeparam name="T">The type of the wrapped object.</typeparam>
public class BaseWrapper<T>
{
    internal PhpArray __peach__runtimeFields;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseWrapper{T}"/> class.
    /// </summary>
    public BaseWrapper()
    {
        _wrappedObject = Activator.CreateInstance<T>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseWrapper{T}"/> class with the specified wrapped object.
    /// </summary>
    /// <param name="wrappedObject">The object to wrap.</param>
    public BaseWrapper(T wrappedObject)
    {
        _wrappedObject = wrappedObject ?? throw new ArgumentNullException(nameof(wrappedObject));
    }

    public T WrappedObject => _wrappedObject;
    
    public PhpValue __get(string propertyName)
    {
        return _getProperty(propertyName);
    }

    public void __set(string propertyName, PhpValue value)
    {
        _setProperty(propertyName, value);
    }
    
    /**
     * Searches for the public property with the specified name.
     */
    private PropertyInfo GetWrappedProperty(string propertyName)
    {
        return _wrappedObject.GetType().GetProperty(propertyName);
    }

    private PhpValue _getProperty(string propertyName)
    {
        var property = GetWrappedProperty(propertyName);
        if (property != null) return PhpValue.FromClr(property.GetValue(_wrappedObject));

        throw new ArgumentException(
            $"Property '{propertyName}' not found on object of type '{_wrappedObject.GetType().Name}'");
    }

    private void _setProperty(string propertyName, PhpValue value)
    {
        var property = GetWrappedProperty(propertyName);
        if (property != null)
            property.SetValue(_wrappedObject, value.ToClr());
        else
            throw new ArgumentException(
                $"Property '{propertyName}' not found on object of type '{_wrappedObject.GetType().Name}'");
    }
    
    public void On(string eventName, Closure callback)
    {
        var eventInfo = _wrappedObject.GetType().GetEvent(eventName.ToString());
        if (eventInfo != null)
            eventInfo.AddEventHandler(_wrappedObject,
                CreateDelegate(eventInfo.EventHandlerType,
                    (_, e) => { callback.call(null, PhpValue.FromClass(this), PhpValue.FromClass(e)); }));
        else
            throw new ArgumentException(
                $"Event '{eventName}' not found on object of type '{_wrappedObject.GetType().Name}'");
    }
    
    private static Delegate CreateDelegate(Type type, EventHandler handler)
    {
        return (Delegate) type.GetConstructor(new[] {typeof(object), typeof(IntPtr)})
            ?.Invoke(new[] {handler.Target, handler.Method.MethodHandle.GetFunctionPointer()});
    }
    
    private readonly T _wrappedObject;
}

