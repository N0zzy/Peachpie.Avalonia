using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ToggleSplitButtonEventsExtension
{
    public static ToggleSplitButton OnIsCheckedChanged(ToggleSplitButton control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.IsCheckedChanged += h);
}