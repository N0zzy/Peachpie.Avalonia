using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

public class ToggleSplitButtonTemplate : ToggleSplitButton, IStyleable
{
    [PhpHidden] public Type StyleKey => typeof(ToggleSplitButton);
}