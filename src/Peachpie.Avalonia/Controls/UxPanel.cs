using Avalonia.Controls;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Base class for controls that can contain multiple children.
/// </summary>
/// <remarks>
/// Controls can be added to a <see cref="UxPanel"/> by adding them to its <see cref="Panel.Children"/>
/// collection. All children are layed out to fill the panel.
/// </remarks>
public class UxPanel : AvaloniaWrapper<Panel>
{
    
}