using System;
using Avalonia;
using Convert = Pchp.Core.Convert;

namespace Peachpie.Avalonia.Experimental;
public class AvaloniaWrapper<T> where T : AvaloniaObject, new()
{
        private T _avaloniaObject;
        
        public AvaloniaWrapper()
        {
            _avaloniaObject = new T();
        }
        
        public T Control => _avaloniaObject;

        public void SetProperty(string propertyName, object value)
        {
            var property = _avaloniaObject.GetType().GetProperty(propertyName);
            if (property != null)
            {
                if (property.PropertyType == typeof(bool))
                {
                    property.SetValue(_avaloniaObject, Convert.ToBoolean(value));
                }
                else if (property.PropertyType == typeof(int))
                {
                    property.SetValue(_avaloniaObject, Convert.ToNumber((string)value));
                }
                else if (property.PropertyType == typeof(double))
                {
                    property.SetValue(_avaloniaObject, Convert.ToDouble(value));
                }
                else if (property.PropertyType == typeof(string))
                {
                    property.SetValue(_avaloniaObject, Convert.ToString(value));
                }
                else
                {
                    throw new ArgumentException($"Unsupported property type: {property.PropertyType}");
                }
            }
            else
            {
                throw new ArgumentException($"Property '{propertyName}' not found on object of type '{_avaloniaObject.GetType().Name}'");
            }
        }

        public object GetProperty(string propertyName)
        {
            var property = _avaloniaObject.GetType().GetProperty(propertyName);
            if (property != null)
            {
                return property.GetValue(_avaloniaObject);
            }
            else
            {
                throw new ArgumentException($"Property '{propertyName}' not found on object of type '{_avaloniaObject.GetType().Name}'");
            }
        }

        public void SetEvent(string eventName, Action<object> action)
        {
            var eventInfo = _avaloniaObject.GetType().GetEvent(eventName);
            if (eventInfo != null)
            {
                var handler = new Action<object>((sender) => action(sender));
                eventInfo.AddEventHandler(_avaloniaObject, handler);
            }
            else
            {
                throw new ArgumentException($"Event '{eventName}' not found on object of type '{_avaloniaObject.GetType().Name}'");
            }
        }
    }
    
