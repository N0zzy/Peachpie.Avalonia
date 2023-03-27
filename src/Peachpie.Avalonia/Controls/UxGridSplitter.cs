using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Represents the control that redistributes space between columns or rows of a <see cref="UxGrid"/> control.
/// </summary>
public class UxGridSplitter<T> : UxThumb<T> where T : GridSplitter
{
    
}

/// <summary>
/// Represents the control that redistributes space between columns or rows of a <see cref="UxGrid"/> control.
/// </summary>
public class UxGridSplitter : UxGridSplitter<GridSplitter>
{
    
}