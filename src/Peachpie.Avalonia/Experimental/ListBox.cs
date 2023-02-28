using System.Collections;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.Experimental;

using System.Collections.Generic;

public class ListBoxWrapper : AvaloniaWrapper<ListBox>
{
        public ListBoxWrapper(PhpArray items) 
        {
            var listBox =  base.Control as ListBox;
            listBox.Items = ConvertItemsToListBoxItems(items);
           
        }
    

        public void SetItems(PhpArray value)
        {
            Control.Items = ConvertItemsToListBoxItems(value);
        }

        public PhpArray Items
        {
            set
            {
                Control.Items = ConvertItemsToListBoxItems(value);
            }
        }
        
        private List<object> ConvertItemsToListBoxItems(PhpArray items)
        {
            var listBoxItems = new List<object>();
            foreach (var item in items)
            {
                var listBoxItem = new ListBoxItem();
                listBoxItem.Content = PhpValue.FromClr(item.Value);
                listBoxItems.Add(listBoxItem);
            }

            return listBoxItems;
        }
}
