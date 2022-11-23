using System;
using Avalonia.Controls.Primitives;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.PrimitivesTemplates
{
    /// <summary>
    /// Represents a control that a user can select (check) or clear (uncheck). Base class for controls that can switch states.
    /// </summary>
    public class ToggleButtonTemplate : ToggleButton , IStyleable
    {
        [PhpHidden] Type IStyleable.StyleKey => typeof(ToggleButton);
        
    }
}
