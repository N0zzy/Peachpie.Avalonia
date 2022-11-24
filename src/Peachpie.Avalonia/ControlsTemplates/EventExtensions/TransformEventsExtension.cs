using System;
using Avalonia.Media;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class TransformEventsExtension
{
    public static Transform OnChanged(Transform control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Changed += h);
}