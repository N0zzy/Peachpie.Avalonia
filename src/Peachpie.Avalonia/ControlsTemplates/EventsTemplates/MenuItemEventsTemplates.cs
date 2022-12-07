using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class MenuItemEventsTemplates
{
    public static PhpValue OnClick(MenuItem control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Click += h));

    public static PhpValue OnPointerEnteredItem(MenuItem control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerEnteredItem += h));

    public static PhpValue OnPointerExitedItem(MenuItem control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerExitedItem += h));

    public static PhpValue OnSubmenuOpened(MenuItem control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.SubmenuOpened += h));
}