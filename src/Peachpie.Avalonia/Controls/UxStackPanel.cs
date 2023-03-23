using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// A panel which lays out its children horizontally or vertically.
/// </summary>
public class UxStackPanel<T> : UxPanel<T> where T : StackPanel
{
    
}

/// <summary>
/// A panel which lays out its children horizontally or vertically.
/// </summary>
public class UxStackPanel : UxStackPanel<StackPanel>
{
    
}
