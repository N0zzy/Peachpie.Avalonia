using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class WindowBaseEventsTemplates
{
    public static PhpValue OnActivated(WindowBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Activated += h));

    public static PhpValue OnDeactivated(WindowBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Deactivated += h));

    public static PhpValue OnPositionChanged(WindowBase control, Action<PixelPointEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PixelPointEventArgs>)((_, args) => action(args)),
            h => control.PositionChanged += h));
}