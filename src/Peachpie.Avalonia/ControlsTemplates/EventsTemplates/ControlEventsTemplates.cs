using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ControlEventsTemplates
{
    public static PhpValue OnContextRequested(Control control, Action<ContextRequestedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ContextRequestedEventArgs>)((_, args) => action(args)),
            h => control.ContextRequested += h));

    public static PhpValue OnLoaded(Control control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Loaded += h));

    public static PhpValue OnUnloaded(Control control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Unloaded += h));

    public static PhpValue OnSizeChanged(Control control, Action<SizeChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SizeChangedEventArgs>)((_, args) => action(args)),
            h => control.SizeChanged += h));
}