using System;
using System.ComponentModel;
using Avalonia.Controls.Primitives;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class FlyoutBaseEventsTemplates
{
    public static PhpValue OnClosed(FlyoutBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Closed += h));

    public static PhpValue OnClosing(FlyoutBase control, Action<CancelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.Closing += h));

    public static PhpValue OnOpened(FlyoutBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h));

    public static PhpValue OnOpening(FlyoutBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Opening += h));
}