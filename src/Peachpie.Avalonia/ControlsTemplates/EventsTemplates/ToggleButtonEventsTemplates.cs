using System;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ToggleButtonEventsTemplates
{
    public static PhpValue OnChecked(ToggleButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Checked += h));

    public static PhpValue OnUnchecked(ToggleButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Unchecked += h));

    public static PhpValue OnIndeterminate(ToggleButton control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Indeterminate += h));
}