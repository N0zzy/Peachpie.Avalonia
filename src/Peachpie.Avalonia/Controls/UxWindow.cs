using System;
using System.Reflection;
using Avalonia.Controls;
using Avalonia.VisualTree;
using Pchp.Core;
using Peachpie.Avalonia.ControlsTemplates;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia.Controls;

[PhpType]
public class UxWindow<T> : BaseWrapper<T> where T : Window, new()
{
    
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

    public void Show()
    {
        GetWrappedObject().Show();
    }
    
    public void Hide()
    {
        GetWrappedObject().Hide();
    }
    
    public void Close()
    {
        GetWrappedObject().Close();
    }
}

public class UxWindow : UxWindow<Window>
{
    
}