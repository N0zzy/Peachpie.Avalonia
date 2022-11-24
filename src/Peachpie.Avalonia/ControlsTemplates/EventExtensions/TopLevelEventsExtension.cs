using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class TopLevelEventsExtension
{
    public static TopLevel OnOpened(TopLevel control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Opened += h);

    public static TopLevel OnClosed(TopLevel control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Closed += h);
}