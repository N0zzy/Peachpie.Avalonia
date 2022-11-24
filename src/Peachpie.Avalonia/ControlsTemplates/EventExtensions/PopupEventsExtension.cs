using System;
using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class PopupEventsExtension
{
    public static Popup OnClosed(Popup control, Action<EventArgs> action) =>
        control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)), h => control.Closed += h);

    public static Popup OnOpened(Popup control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h);
}