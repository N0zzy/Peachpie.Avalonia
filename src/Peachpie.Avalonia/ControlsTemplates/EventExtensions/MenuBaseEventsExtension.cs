using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class MenuBaseEventsExtension
{
    public static MenuBase OnMenuOpened(MenuBase control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.MenuOpened += h);

    public static MenuBase OnMenuClosed(MenuBase control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.MenuClosed += h);
}