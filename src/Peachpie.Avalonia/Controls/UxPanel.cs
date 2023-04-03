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
        Children.CollectionChanged += CollectionChanged;
    }


    /// <summary>
    /// Gets the children of the <see cref="T:UxPanel" />.
    /// </summary>
    public UxControls Children { get; } = new();

    // обработчик изменения коллекции
    private void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                foreach (var item in e.NewItems)
                    if (item is PhpValue newUxControl)
                    {
                        var control = (IUxControl)newUxControl.ToClr();
                        WrappedObject.Children.Add((Control)control.WrappedControl);
                    }
                    else
                    {
                        throw new ArgumentException("-------");
                    }

                break;
            case NotifyCollectionChangedAction.Remove: // если удаление
                foreach (var item in e.OldItems)
                    if (item is PhpValue oldUxControl)
                    {
                        var control = (IUxControl)oldUxControl.ToClr();
                        WrappedObject.Children.Remove((Control)control.WrappedControl);
                    }
                    else
                    {
                        throw new ArgumentException("-------");
                    }

                break;
            case NotifyCollectionChangedAction.Reset:
                WrappedObject.Children.Clear();
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