using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// A control with two views: A collapsible pane and an area for content
/// </summary>
public class UxSplitView<T> : UxContentControl<T> where T : SplitView
{
    
}

/// <summary>
/// A control with two views: A collapsible pane and an area for content
/// </summary>
public class UxSplitView : UxSplitView<SplitView>
{
    
}