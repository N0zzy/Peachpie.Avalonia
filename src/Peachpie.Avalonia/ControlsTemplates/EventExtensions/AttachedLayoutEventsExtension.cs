using System;
using Avalonia.Layout;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class AttachedLayoutEventsExtension
{
    public static AttachedLayout OnMeasureInvalidated(AttachedLayout control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.MeasureInvalidated += h);

    public static AttachedLayout OnArrangeInvalidated(AttachedLayout control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.ArrangeInvalidated += h);
}