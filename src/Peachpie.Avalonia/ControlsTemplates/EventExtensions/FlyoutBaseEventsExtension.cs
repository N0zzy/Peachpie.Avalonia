using System;
using System.ComponentModel;
using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class FlyoutBaseEventsExtension
{
    public static FlyoutBase OnClosed(FlyoutBase control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Closed += h);

    public static FlyoutBase OnClosing(FlyoutBase control, Action<CancelEventArgs> action) =>
        control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)), h => control.Closing += h);

    public static FlyoutBase OnOpened(FlyoutBase control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h);

    public static FlyoutBase OnOpening(FlyoutBase control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Opening += h);
}