using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class TopLevelEventsTemplates
{
    public static PhpValue OnOpened(TopLevel control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h));

    public static PhpValue OnClosed(TopLevel control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Closed += h));
}