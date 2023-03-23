using Avalonia;
using Avalonia.Rendering;

namespace Peachpie.Avalonia;

/// <summary>
/// Base class for controls that provides rendering and related visual properties.
/// </summary>
/// <remarks>
/// The <see cref="Visual"/> class represents elements that have a visual on-screen
/// representation and stores all the information needed for an 
/// <see cref="IRenderer"/> to render the control. To traverse the visual tree, use the
/// extension methods defined in <see cref="VisualExtensions"/>.
/// </remarks>
public class UxVisual<T> : UxStyledElement<T> where T : Visual
{
 
}

/// <summary>
/// Base class for controls that provides rendering and related visual properties.
/// </summary>
/// <remarks>
/// The <see cref="UxVisual"/> class represents elements that have a visual on-screen
/// representation and stores all the information needed for an 
/// <see cref="IRenderer"/> to render the control. To traverse the visual tree, use the
/// extension methods defined in <see cref="VisualExtensions"/>.
/// </remarks>
public class UxVisual : UxVisual<Visual>
{
    
}