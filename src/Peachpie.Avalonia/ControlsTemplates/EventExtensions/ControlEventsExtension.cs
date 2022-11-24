using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ControlEventsExtension
{
    public static Control OnContextRequested(Control control, Action<ContextRequestedEventArgs> action) =>
        control._setEvent((EventHandler<ContextRequestedEventArgs>)((_, args) => action(args)),
            h => control.ContextRequested += h);

    public static Control OnLoaded(Control control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.Loaded += h);

    public static Control OnUnloaded(Control control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.Unloaded += h);
}