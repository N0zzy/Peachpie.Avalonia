using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// A control which scrolls its content if the content is bigger than the space available.
/// </summary>
public class UxScrollViewer<T> : UxContentControl<T> where T : ScrollViewer
{
    
}

/// <summary>
/// A control which scrolls its content if the content is bigger than the space available.
/// </summary>
public class UxScrollViewer : UxScrollViewer<ScrollViewer>
{
    
}