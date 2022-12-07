using System;
using Avalonia.Media;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class GeometryEventsTemplates
{
    public static PhpValue OnChanged(Geometry control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Changed += h));
}