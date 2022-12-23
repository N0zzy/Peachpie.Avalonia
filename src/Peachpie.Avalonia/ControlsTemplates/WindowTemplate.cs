using System;
using System.Reflection;
using Avalonia.Controls;
using Avalonia.VisualTree;

namespace Peachpie.Avalonia.ControlsTemplates;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class EventAttribute : Attribute
{
    public readonly string EventControl;
    public readonly string EventName;
    
    public EventAttribute(string eventControl, string eventName)
    {
        EventControl = eventControl;
        EventName = eventName;
    }
}

/// <summary>
/// A top-level window.
/// </summary>
public class WindowTemplate : Window
{
    public void Test()
    {
        foreach (var method in GetType().GetMethods())
        {
            var attribute = method.GetCustomAttribute<EventAttribute>();
            if (attribute != null)
            {
                //Перечисляет IVisual и его потомков в визуальном дереве.
                foreach (var value in this.GetSelfAndVisualDescendants())
                {
                    var obj = value as Control;
                    if (obj?.Name == attribute.EventControl)
                    {
                        var controlEvent = obj?.GetType().GetMethod(attribute.EventName);
                        controlEvent?.Invoke(obj, new object[]
                        {
                            (EventArgs a) => { method?.Invoke(this, new object[] {obj!, a}); }
                        });
                    }
                }
            }
        }
    }
    
}
