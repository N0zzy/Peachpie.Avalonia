using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Pchp.Core;
using Peachpie.Avalonia.Collections;
using Peachpie.Avalonia.Controls.Primitives;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// An <see cref="UxItemsControl"/> in which individual items can be selected.
/// </summary>
public class UxListBox<T> : UxSelectingItemsControl<T> where T : ListBox
{
    public UxListBox()
    {
        Items = _items;
    }
    
    public UxList Items
    {
        set => WrappedObject.Items = value;
        get => WrappedObject.Items as UxList;
    }

    public void SelectAll()
    {
        WrappedObject.SelectAll();
    }
    
    public void UnSelectAll()
    {
        WrappedObject.UnselectAll();
    }
    
    public void Arrange(Rect rect)
    {
        WrappedObject.Arrange(rect);
    }
    
    
    private UxList _items = new();
}

/// <summary>
/// An <see cref="UxItemsControl"/> in which individual items can be selected.
/// </summary>
public class UxListBox : UxListBox<ListBox>
{
    
}
