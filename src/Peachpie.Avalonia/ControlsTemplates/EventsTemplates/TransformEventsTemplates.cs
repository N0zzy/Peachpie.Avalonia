using System;
using Avalonia.Media;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class TransformEventsTemplates
{
    public static PhpValue OnChanged(Transform control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Changed += h));
}