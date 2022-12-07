using System;
using Avalonia.Layout;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class AttachedLayoutEventsTemplates
{
    public static PhpValue OnMeasureInvalidated(AttachedLayout control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.MeasureInvalidated += h));

    public static PhpValue OnArrangeInvalidated(AttachedLayout control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.ArrangeInvalidated += h));
}