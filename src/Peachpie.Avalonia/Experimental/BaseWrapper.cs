using System;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Reflection.Emit;
using Avalonia;
using Avalonia.Interactivity;
using Pchp.Core;
using Pchp.Core.Reflection;
using Peachpie.Avalonia.ControlsTemplates.EventsTemplates;
using Convert = Pchp.Core.Convert;

namespace Peachpie.Avalonia.Experimental;
public class BaseWrapper<T> where T : AvaloniaObject, new()
{
        protected T _wrappedObject;
        
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
                
                
            }
            else
            {
                throw new ArgumentException($"Event '{eventName}' not found on object of type '{_wrappedObject.GetType().Name}'");
            }
        }
    }
    
