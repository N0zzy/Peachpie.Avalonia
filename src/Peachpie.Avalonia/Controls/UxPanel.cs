using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Pchp.Core;
using Peachpie.Avalonia.Collections;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Base class for controls that can contain multiple children.
/// </summary>
/// <remarks>
/// Controls can be added to a <see cref="UxPanel"/> by adding them to its <see cref="Panel.Children"/>
/// collection. All children are layed out to fill the panel.
/// </remarks>
public class UxPanel<T> : UxControl<T> where T : Panel
{
    /*public UxPanel()
    {
        Children.CollectionChanged += ChildrenOnCollectionChanged;
    }

    private void ChildrenOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
    {
        switch (e.Action)
        {
            case NotifyCollectionChangedAction.Add:
                foreach (var item in e.NewItems)
                {
                    WrappedObject.Children.Add((Control)item);
                }
                
                break;
            
            case NotifyCollectionChangedAction.Move:
                WrappedObject.Children.MoveRange(e.OldStartingIndex, e.OldItems!.Count, e.NewStartingIndex);
                WrappedObject.Children.MoveRange(e.OldStartingIndex, e.OldItems.Count, e.NewStartingIndex);
                break;
            
        }
    }
    
    public readonly UxControls Children = new();*/
}

/// <summary>
/// Base class for controls that can contain multiple children.
/// </summary>
/// <remarks>
/// Controls can be added to a <see cref="UxPanel"/> by adding them to its <see cref="Panel.Children"/>
/// collection. All children are layed out to fill the panel.
/// </remarks>
public class UxPanel : UxPanel<Panel>
{
    
}