using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls.Primitives;

/// <summary>
/// Displays a strip of selectable tabs.
/// </summary>
public class UxTabStrip<T> : UxSelectingItemsControl<T> where T: TabStrip
{
    
}

/// <summary>
/// Displays a strip of selectable tabs.
/// </summary>
public class UxTabStrip : UxTabStrip<TabStrip>
{
    
}