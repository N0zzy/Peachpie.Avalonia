using System;
using Avalonia.Controls.Primitives;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class PopupEventsTemplates
{
    public static PhpValue OnClosed(Popup control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.Closed += h));

    public static PhpValue OnOpened(Popup control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h));
}