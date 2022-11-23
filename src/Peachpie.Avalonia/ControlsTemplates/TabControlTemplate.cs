using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

public class TabControlTemplate : TabControl, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(TabControl);

}