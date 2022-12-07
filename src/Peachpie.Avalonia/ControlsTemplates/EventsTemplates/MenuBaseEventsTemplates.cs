using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class MenuBaseEventsTemplates
{
    public static PhpValue OnMenuOpened(MenuBase control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.MenuOpened += h));

    public static PhpValue OnMenuClosed(MenuBase control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.MenuClosed += h));
}