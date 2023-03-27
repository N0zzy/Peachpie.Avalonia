using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Displays a hierarchical tree of data.
/// </summary>
public class UxTreeView<T> : UxItemsControl<T> where T : TreeView
{
    
}

/// <summary>
/// Displays a hierarchical tree of data.
/// </summary>
public class UxTreeView : UxTreeView<TreeView>
{
    
}