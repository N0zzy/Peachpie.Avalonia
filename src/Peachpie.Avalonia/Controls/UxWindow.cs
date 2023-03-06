using System;
using System.Reflection;
using Avalonia.Controls;
using Avalonia.VisualTree;
using Pchp.Core;
using Peachpie.Avalonia.ControlsTemplates;

namespace Peachpie.Avalonia.Controls;

[PhpType]
public class UxWindow : AvaloniaWrapper<Window>
{

    public UxWindow()
    {
        
    }
    
    
    /// <summary>
    /// Заменить эту  страшную штуку
    /// </summary>
    public void SetEventsAttribute( Control panel )
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