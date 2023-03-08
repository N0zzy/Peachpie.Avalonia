using Avalonia;
using Avalonia.Controls;
using Pchp.Core;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia.Controls;

public class UxListBox : AvaloniaWrapper<ListBox>
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