using Avalonia;
using Avalonia.LogicalTree;
using Avalonia.Styling;
using Peachpie.Avalonia.Animation;

namespace Peachpie.Avalonia;

/// <summary>
/// Extends an <see cref="UxAnimatable"/> with the following features:
/// 
/// - An inherited <see cref="DataContext"/>.
/// - Implements <see cref="IStyleable"/> to allow styling to work on the styled element.
/// - Implements <see cref="ILogical"/> to form part of a logical tree.
/// - A collection of class strings for custom styling.
/// </summary>
public class UxStyledElement<T> : UxAnimatable<T> where T : StyledElement, new()
{
    
}

/// <summary>
/// Extends an <see cref="UxAnimatable"/> with the following features:
/// 
/// - An inherited <see cref="DataContext"/>.
/// - Implements <see cref="IStyleable"/> to allow styling to work on the styled element.
/// - Implements <see cref="ILogical"/> to form part of a logical tree.
/// - A collection of class strings for custom styling.
/// </summary>
public class UxStyledElement : UxStyledElement<StyledElement>
{
    
}