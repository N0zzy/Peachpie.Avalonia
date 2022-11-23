using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

[PhpType]
public class SplitButtonTemplate : SplitButton , IStyleable
{
    [PhpHidden] public Type StyleKey => typeof(SplitButton);
}