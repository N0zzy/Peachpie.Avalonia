using System;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ToggleButtonEventsExtension
{
    public static ToggleButton OnChecked(ToggleButton control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.Checked += h);

    public static ToggleButton OnUnchecked(ToggleButton control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.Unchecked += h);

    public static ToggleButton OnIndeterminate(ToggleButton control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.Indeterminate += h);
}