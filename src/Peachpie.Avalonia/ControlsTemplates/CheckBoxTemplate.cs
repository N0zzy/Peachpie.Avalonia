using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;
using Peachpie.Avalonia.ControlsTemplates.PrimitivesTemplates;

namespace Peachpie.Avalonia.ControlsTemplates;

/// <summary>
/// A check box control.
/// </summary>
public class CheckBoxTemplate : ToggleButtonTemplate, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(CheckBox);
}