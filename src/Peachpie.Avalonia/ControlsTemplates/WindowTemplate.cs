using System;
using System.Reflection;
using Avalonia.Controls;
using Avalonia.VisualTree;
using Pchp.Core;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia.ControlsTemplates;

/// <summary>
/// A top-level window.
/// </summary>
public class WindowTemplate : Window
{
    public void SetEventsAttribute(StackPanelTemplate panel)
    {
        foreach (var method in GetType().GetMethods())
        {
            var attribute = method.GetCustomAttribute<EventAttribute>();
            if (attribute != null)
            {
                //Перечисляет IVisual и его потомков в визуальном дереве.
                foreach (var value in panel.GetSelfAndVisualDescendants())
                {
                    var obj = value as Control;
                    if (obj?.Name == attribute.EventControl)
                    {
                        var controlEvent = value.GetType().GetMethod(attribute.EventName);
                        controlEvent?.Invoke(value, new object[]
                        {
                            PhpValue.FromClass((EventArgs a) =>
                            {
                                method.Invoke(this, new object[] {value, PhpValue.FromClass(a)});
                            })
                        });
                    }
                }
            }
        }
    }
}
