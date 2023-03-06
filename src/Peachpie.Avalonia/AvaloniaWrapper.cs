using System;
using Avalonia;
using Pchp.Core;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia;

public class AvaloniaWrapper<T> : BaseWrapper<T> where T : AvaloniaObject, new()
{
  
    static Delegate CreateDelegate(Type type, EventHandler handler)
    {
        return (Delegate) type.GetConstructor(new[] {typeof(object), typeof(IntPtr)})
            ?.Invoke(new[] {handler.Target, handler.Method.MethodHandle.GetFunctionPointer()});
    }

    public void On(PhpValue eventName, Closure callback)
    {
        var eventInfo = GetWrappedObject().GetType().GetEvent(eventName.ToString());
        if (eventInfo != null)
        {
            eventInfo.AddEventHandler(GetWrappedObject(),
                CreateDelegate(eventInfo.EventHandlerType,
                    (sender, e) => { callback.call(null, PhpValue.FromClass(GetWrappedObject()), PhpValue.FromClass(e)); }));
        }
        else
        {
            throw new ArgumentException(
                $"Event '{eventName}' not found on object of type '{GetWrappedObject().GetType().Name}'");
        }
    }
    
    
    
}