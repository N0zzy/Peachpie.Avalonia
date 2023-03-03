using System;
using Avalonia;
using Pchp.Core;

namespace Peachpie.Avalonia.Experimental;


public class BaseWrapper<T> where T : AvaloniaObject, new()
{
        protected T _wrappedObject;
        
        static Delegate CreateDelegate(Type type, EventHandler handler)
        {
            return (Delegate)type.GetConstructor(new [] { typeof(object), typeof(IntPtr) })
                .Invoke(new [] { handler.Target, handler.Method.MethodHandle.GetFunctionPointer() });
        }
        
        public BaseWrapper()
        {
            _wrappedObject = new T();
        }
        
        public T Control => _wrappedObject;

        public void SetProperty(string propertyName, PhpValue value)
        {
            var property = _wrappedObject.GetType().GetProperty(propertyName);
            if (property != null)
            {
                property.SetValue(_wrappedObject, value);
            }
            else
            {
                throw new ArgumentException($"Property '{propertyName}' not found on object of type '{_wrappedObject.GetType().Name}'");
            }
        }

        public PhpValue GetProperty(string propertyName)
        {
            var property = _wrappedObject.GetType().GetProperty(propertyName);
            if (property != null)
            {
                return PhpValue.FromClass(property.GetValue(_wrappedObject));
            }
            else
            {
                throw new ArgumentException($"Property '{propertyName}' not found on object of type '{_wrappedObject.GetType().Name}'");
            }
        }
        
        public void On(string eventName, Closure callback)
        {
            
            var eventInfo = _wrappedObject.GetType().GetEvent(eventName);
            if (eventInfo != null)
            {
                
               //eventInfo.AddEventHandler(_wrappedObject, myEventHandler );
               eventInfo.AddEventHandler(_wrappedObject, CreateDelegate(eventInfo.EventHandlerType, (sender, e) =>
               {
                   callback.call(null, PhpValue.FromClass(sender), PhpValue.FromClass(e));
               }));
            }
            else
            {
                throw new ArgumentException($"Event '{eventName}' not found on object of type '{_wrappedObject.GetType().Name}'");
            }
        }
    }
    
