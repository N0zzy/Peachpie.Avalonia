using System;
using Avalonia.Layout;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class LayoutableEventsExtension
{
    public static Layoutable OnEffectiveViewportChanged(Layoutable control,
        Action<EffectiveViewportChangedEventArgs> action) =>
        control._setEvent((EventHandler<EffectiveViewportChangedEventArgs>)((_, args) => action(args)),
            h => control.EffectiveViewportChanged += h);

    public static Layoutable OnLayoutUpdated(Layoutable control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.LayoutUpdated += h);
}