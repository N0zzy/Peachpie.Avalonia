using System;
using Avalonia.Media;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class DashStyleEventsExtension
{
    public static DashStyle OnInvalidated(DashStyle control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h);
}