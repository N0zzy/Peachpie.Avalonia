using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class TrayIconEventsExtension
{
    public static TrayIcon OnClicked(TrayIcon control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Clicked += h);
}