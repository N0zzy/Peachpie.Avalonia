using System;
using System.Collections.Specialized;
using Avalonia.Controls;
using Pchp.Core;
using Peachpie.Avalonia.Controls.Interfaces;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Base class for controls that can contain multiple children.
/// </summary>
/// <remarks>
/// Controls can be added to a <see cref="UxPanel"/> by adding them to its <see cref="Children"/>
/// collection. All children are layed out to fill the panel.
/// </remarks>
public class UxPanel<T> : UxControl<T> where T : Panel
{
    public UxPanel()
    {
        Children.CollectionChanged += UxControl_CollectionChanged;
    }
    

    /// <summary>
    /// Gets the children of the <see cref="T:UxPanel" />.
    /// </summary>
    public UxControls Children { get; } = new();

    // обработчик изменения коллекции
    void UxControl_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            
            case NotifyCollectionChangedAction.Add: 
                if (e.NewItems?[0] is PhpValue newUxControl)
                {
                    var control = (IUxControl) newUxControl.ToClass();
                    WrappedObject.Children.Add((Control) control.WrappedControl);
                }
                else
                    throw new ArgumentException("-------");
                
                break;
            case NotifyCollectionChangedAction.Remove: // если удаление
                if (e.OldItems?[0] is PhpValue oldUxControl)
                {
                    var control = (IUxControl) oldUxControl.ToClass();
                    WrappedObject.Children.Remove((Control) control.WrappedControl);
                }

                break;
        }
    }
    
}


/// <summary>
/// Base class for controls that can contain multiple children.
/// </summary>
/// <remarks>
/// Controls can be added to a <see cref="UxPanel"/> by adding them to its <see cref="UxPanel{T}.Children"/>
/// collection. All children are layed out to fill the panel.
/// </remarks>
public class UxPanel : UxPanel<Panel>
{
    
}