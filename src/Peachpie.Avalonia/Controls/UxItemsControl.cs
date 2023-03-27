using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Displays a collection of items.
/// </summary>
public class UxItemsControl<T> : UxTemplatedControl<T> where T : ItemsControl
{
    
}

/// <summary>
/// Displays a collection of items.
/// </summary>
public class UxItemsControl : UxItemsControl<ItemsControl>
{
    
}