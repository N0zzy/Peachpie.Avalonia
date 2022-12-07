using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class NativeMenuEventsTemplates
{
    public static PhpValue OnNeedsUpdate(NativeMenu control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.NeedsUpdate += h));

    public static PhpValue OnOpening(NativeMenu control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.Opening += h));

    public static PhpValue OnClosed(NativeMenu control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.Closed += h));
}