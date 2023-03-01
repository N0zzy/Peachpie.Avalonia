using System.Collections;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.Experimental;

using System.Collections.Generic;

public class ListBoxWrapper : BaseWrapper<ListBox>
{
        public ListBoxWrapper() 
        {
        }
        
        public PhpArray Items
        {
            set => Control.Items = ConvertItemsToListBoxItems(value);
            get => ConvertListBoxItemsToItems(Control.Items);
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
