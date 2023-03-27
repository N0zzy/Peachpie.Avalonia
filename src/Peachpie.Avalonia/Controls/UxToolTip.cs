using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// A control which pops up a hint when a control is hovered.
/// </summary>
/// <remarks>
/// You will probably not want to create a <see cref="UxToolTip"/> control directly: if added to
/// the tree it will act as a simple <see cref="UxContentControl"/> styled to look like a tooltip.
/// To add a tooltip to a control, use the <see cref="ToolTip.TipProperty"/> attached property,
/// assigning the content that you want displayed.
/// </remarks>
public class UxToolTip<T> : UxContentControl<T> where T: ToolTip
{
    
}

/// <summary>
/// A control which pops up a hint when a control is hovered.
/// </summary>
/// <remarks>
/// You will probably not want to create a <see cref="UxToolTip"/> control directly: if added to
/// the tree it will act as a simple <see cref="UxContentControl"/> styled to look like a tooltip.
/// To add a tooltip to a control, use the <see cref="ToolTip.TipProperty"/> attached property,
/// assigning the content that you want displayed.
/// </remarks>
public class UxToolTip : UxToolTip<ToolTip>
{
    
}