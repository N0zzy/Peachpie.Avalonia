using System;
using System.Reflection;
using Pchp.Core;

namespace Peachpie.Avalonia.Experimental;

public class BaseWrapper<T> where T : new()
{
    public T GetWrappedObject()
    {
        return _wrappedObject;
    }
    
    public void SetProperty(PhpValue propertyName, PhpValue value)
    {
        var property = GetWrappedProperty(propertyName, value);
        
        if (property != null)
            property.SetValue(_wrappedObject, value.ToClr());
        else
            throw new ArgumentException(
                $"Property '{propertyName}' not found on object of type '{_wrappedObject.GetType().Name}'");
    }

    public PhpValue GetProperty(PhpValue propertyName)
    {
        var property = GetWrappedProperty(propertyName, propertyName);
        if (property != null) return PhpValue.FromClr(property.GetValue(_wrappedObject));

        throw new ArgumentException(
            $"Property '{propertyName}' not found on object of type '{_wrappedObject.GetType().Name}'");
    }
    
    private static Delegate CreateDelegate(Type type, EventHandler handler)
    {
        return (Delegate) type.GetConstructor(new[] {typeof(object), typeof(IntPtr)})
            ?.Invoke(new[] {handler.Target, handler.Method.MethodHandle.GetFunctionPointer()});
    }

    /**
     * Searches for the public property with the specified name.
     */
    private PropertyInfo GetWrappedProperty(PhpValue propertyName, PhpValue value)
    {
        return _wrappedObject.GetType().GetProperty(propertyName.ToString());
    }
    
    private readonly T _wrappedObject = new();
}
    
