using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

public class ListBoxTemplate : ListBox, IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(ListBox);
}