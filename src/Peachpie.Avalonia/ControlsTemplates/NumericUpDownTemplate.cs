using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

public class NumericUpDownTemplate : NumericUpDown, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(NumericUpDown);
}