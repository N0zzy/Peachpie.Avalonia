using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class MenuItemEventsExtension
{
    public static MenuItem OnClick(MenuItem control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.Click += h);

    public static MenuItem OnPointerEnteredItem(MenuItem control, Action<PointerEventArgs> action) =>
        control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerEnteredItem += h);

    public static MenuItem OnPointerExitedItem(MenuItem control, Action<PointerEventArgs> action) =>
        control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerExitedItem += h);

    public static MenuItem OnSubmenuOpened(MenuItem control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.SubmenuOpened += h);
}