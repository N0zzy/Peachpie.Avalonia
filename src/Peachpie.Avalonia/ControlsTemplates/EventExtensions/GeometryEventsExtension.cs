using System;
using Avalonia.Media;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class GeometryEventsExtension
{
    public static Geometry OnChanged(Geometry control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Changed += h);
}