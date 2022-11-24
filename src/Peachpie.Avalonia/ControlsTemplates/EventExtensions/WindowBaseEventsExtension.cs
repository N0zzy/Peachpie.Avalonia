using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class WindowBaseEventsExtension
{
    public static WindowBase OnActivated(WindowBase control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Activated += h);

    public static WindowBase OnDeactivated(WindowBase control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Deactivated += h);

    public static WindowBase OnPositionChanged(WindowBase control, Action<PixelPointEventArgs> action) =>
        control._setEvent((EventHandler<PixelPointEventArgs>)((_, args) => action(args)),
            h => control.PositionChanged += h);
}