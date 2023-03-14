using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

public class UxItemsControl<T> : UxTemplatedControl<T> where T : ItemsControl, new()
{
    
}

public class UxItemsControl : UxItemsControl<ItemsControl>
{
    
}