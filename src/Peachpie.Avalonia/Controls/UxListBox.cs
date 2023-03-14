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
public class UxListBox<T> : UxSelectingItemsControl<T> where T : ListBox, new()
{
    public UxListBox()
    {
        Items = _items;
    }
    
    public UxList Items
    {
        set => GetWrappedObject().Items = value;
        get => GetWrappedObject().Items as UxList;
    }

    public void SelectAll()
    {
        GetWrappedObject().SelectAll();
    }
    
    public void UnSelectAll()
    {
        GetWrappedObject().UnselectAll();
    }
    
    public void Arrange(Rect rect)
    {
        GetWrappedObject().Arrange(rect);
    }
    
    
    private UxList _items = new();
}

/// <summary>
/// An <see cref="UxItemsControl"/> in which individual items can be selected.
/// </summary>
public class UxListBox : UxListBox<ListBox>
{
    
}
