using System;

namespace Peachpie.Avalonia.ControlsTemplates;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class EventAttribute : Attribute
{
    public readonly string EventControl;
    public readonly string EventName;
    
    public EventAttribute(string eventControl, string eventName)
    {
        EventControl = eventControl;
        EventName = eventName;
    }
}