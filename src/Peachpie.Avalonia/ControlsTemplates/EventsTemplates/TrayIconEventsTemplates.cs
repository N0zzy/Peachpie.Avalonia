using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class TrayIconEventsTemplates
{
    public static PhpValue OnClicked(TrayIcon control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Clicked += h));
}