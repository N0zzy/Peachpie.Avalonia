using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;


/// <summary>
/// A panel that displays child controls at arbitrary locations.
/// </summary>
/// <remarks>
/// Unlike other <see cref="UxPanel"/> implementations, the <see cref="UxCanvas"/> doesn't lay out
/// its children in any particular layout. Instead, the positioning of each child control is
/// defined by the <code>Canvas.Left</code>, <code>Canvas.Top</code>, <code>Canvas.Right</code>
/// and <code>Canvas.Bottom</code> attached properties.
/// </remarks>
public class UxCanvas<T> : UxPanel<T> where T: Panel, new()
{

}

/// <summary>
/// A panel that displays child controls at arbitrary locations.
/// </summary>
/// <remarks>
/// Unlike other <see cref="UxPanel"/> implementations, the <see cref="UxCanvas"/> doesn't lay out
/// its children in any particular layout. Instead, the positioning of each child control is
/// defined by the <code>Canvas.Left</code>, <code>Canvas.Top</code>, <code>Canvas.Right</code>
/// and <code>Canvas.Bottom</code> attached properties.
/// </remarks>
public class UxCanvas : UxPanel<Panel>
{

}