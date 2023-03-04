using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.Controls;

[PhpType]
public class UxListBox : AvaloniaWrapper<ListBox>
{
    public UxListBox()
    {
        /*
         var people = new ObservableCollection<PhpValue>
        {
            "Tom", "Bob", "Sam"
        };
        
        var te = GetWrappedObject().Items = people;
        
        people.Add("ddddddddd");
        */
    }
    
    public PhpArray Items
    {
        set => GetWrappedObject().Items = ConvertItemsToListBoxItems(value);
        get => ConvertListBoxItemsToItems(GetWrappedObject().Items);
    }
        
    private IEnumerable ConvertItemsToListBoxItems(PhpArray items)
    {
        var listBoxItems = new List<object>();
        foreach (var item in items)
        {
            var listBoxItem = new ListBoxItem();
            listBoxItem.Content = PhpValue.FromClass(item.Value);
            listBoxItems.Add(listBoxItem);
        }
            
        return listBoxItems;
    }
        
    private PhpArray ConvertListBoxItemsToItems(IEnumerable listBoxItems)
    {
        var items = new PhpArray();
        foreach (var listBoxItem in listBoxItems)
        {
            items.Add(PhpValue.FromClass(listBoxItem));
        }

        return items;
    }
}