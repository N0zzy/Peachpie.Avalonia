using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

/// <summary>
/// A standard button control.
/// </summary>
public class ButtonTemplate : Button , IStyleable
{
    [PhpHidden] public Type StyleKey => typeof(Button);
}