using System;
using Avalonia.Controls;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates;

public class CalendarTemplate : Calendar , IStyleable
{
    [PhpHidden] Type IStyleable.StyleKey => typeof(Calendar);
    
}