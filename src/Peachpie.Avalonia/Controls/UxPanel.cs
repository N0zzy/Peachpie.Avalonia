using System;
using System.Collections.Specialized;
using Avalonia.Controls;
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

    public void Remove(IUxControl uxControl)
    {
        Children.Remove(uxControl);
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
                if (e.NewItems?[0] is IUxControl newUxControl)
                {
                    Console.WriteLine($"Добавлен новый объект: {newUxControl}");
                    WrappedObject.Children.Add((Control) newUxControl.WrappedControl);
                }
                break;
            case NotifyCollectionChangedAction.Remove: // если удаление
                Console.WriteLine($"Удален объект: {e.OldItems?[0]}");
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