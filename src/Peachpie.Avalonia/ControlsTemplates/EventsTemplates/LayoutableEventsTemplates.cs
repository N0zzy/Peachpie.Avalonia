using System;
using Avalonia.Layout;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class LayoutableEventsTemplates
{
    public static PhpValue OnEffectiveViewportChanged(Layoutable control,
        Action<EffectiveViewportChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<EffectiveViewportChangedEventArgs>)((_, args) => action(args)),
            h => control.EffectiveViewportChanged += h));

    public static PhpValue OnLayoutUpdated(Layoutable control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.LayoutUpdated += h));
}