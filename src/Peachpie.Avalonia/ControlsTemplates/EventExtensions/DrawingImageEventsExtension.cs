using System;
using Avalonia.Media;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class DrawingImageEventsExtension
{
    public static DrawingImage OnInvalidated(DrawingImage control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h);
}