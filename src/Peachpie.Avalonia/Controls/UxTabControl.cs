using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// A tab control that displays a tab strip along with the content of the selected tab.
/// </summary>
public class UxTabControl<T> : UxSelectingItemsControl<T> where T: TabControl
{
    
}

/// <summary>
/// A tab control that displays a tab strip along with the content of the selected tab.
/// </summary>
public class UxTabControl : UxTabControl<TabControl>
{
    
}