using System;
using System.ComponentModel;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ContextMenuEventsTemplates
{
    public static PhpValue OnContextMenuOpening(ContextMenu control, Action action) =>
        PhpValue.FromClass(control._setEvent((CancelEventHandler)((_, args) => action()),
            h => control.ContextMenuOpening += h));

    public static PhpValue OnContextMenuClosing(ContextMenu control, Action action) =>
        PhpValue.FromClass(control._setEvent((CancelEventHandler)((_, args) => action()),
            h => control.ContextMenuClosing += h));
}