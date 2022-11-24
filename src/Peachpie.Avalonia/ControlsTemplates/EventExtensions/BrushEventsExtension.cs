using System;
using Avalonia.Media;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class BrushEventsExtension
{
    public static Brush OnInvalidated(Brush control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h);
}