using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ToggleSplitButtonEventsTemplates
{
    public static PhpValue OnIsCheckedChanged(ToggleSplitButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.IsCheckedChanged += h));
}