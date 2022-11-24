using System;
using Avalonia.Media;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class PenEventsExtension
{
    public static Pen OnInvalidated(Pen control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h);
}