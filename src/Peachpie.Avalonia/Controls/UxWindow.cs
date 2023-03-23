using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Avalonia.Controls;
using Avalonia.VisualTree;
using Pchp.Core;
using Peachpie.Avalonia.ControlsTemplates;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia.Controls;

[PhpType]
public class UxWindow<T> : UxWindowBase<T> where T : Window
{
    public UxWindow()
    {
        UxWindowsList.Add(this);
    }

    public UxWindow<T> Form(string name)
    {
        return UxWindowsList.FirstOrDefault(x => x.WrappedObject.Name == name);
    } 
    
    /// <summary>
    /// Заменить эту  страшную штуку
    /// </summary>
    public void SetEventsAttribute(Control panel)
    {
        foreach (var method in GetType().GetMethods())
        {
            var attribute = method.GetCustomAttribute<EventAttribute>();
            if (attribute != null)
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

    /// <summary>
    /// Shows the window.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The window has already been closed.
    /// </exception>
    public void Show()
    {
        WrappedObject.Show();
    }

    /// <summary>
    /// Hides the window but does not close it.
    /// </summary>
    public void Hide()
    {
        WrappedObject.Hide();
    }

    public void Close()
    {
        WrappedObject.Close();
    }
    
    [PhpHidden] private static readonly List<UxWindow<T>> UxWindowsList = new();
}

public class UxWindow : UxWindow<Window>
{
    
}