using System;
using System.ComponentModel;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class AutoCompleteBoxEventsExtension
{
    public static AutoCompleteBox OnTextChanged(AutoCompleteBox control, Action<TextChangedEventArgs> action) =>
        control._setEvent((EventHandler<TextChangedEventArgs>)((_, args) => action(args)),
            h => control.TextChanged += h);

    public static AutoCompleteBox OnPopulating(AutoCompleteBox control, Action<PopulatingEventArgs> action) =>
        control._setEvent((EventHandler<PopulatingEventArgs>)((_, args) => action(args)), h => control.Populating += h);

    public static AutoCompleteBox OnPopulated(AutoCompleteBox control, Action<PopulatedEventArgs> action) =>
        control._setEvent((EventHandler<PopulatedEventArgs>)((_, args) => action(args)), h => control.Populated += h);

    public static AutoCompleteBox OnDropDownOpening(AutoCompleteBox control, Action<CancelEventArgs> action) =>
        control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.DropDownOpening += h);

    public static AutoCompleteBox OnDropDownOpened(AutoCompleteBox control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.DropDownOpened += h);

    public static AutoCompleteBox OnDropDownClosing(AutoCompleteBox control, Action<CancelEventArgs> action) =>
        control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.DropDownClosing += h);

    public static AutoCompleteBox OnDropDownClosed(AutoCompleteBox control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.DropDownClosed += h);

    public static AutoCompleteBox
        OnSelectionChanged(AutoCompleteBox control, Action<SelectionChangedEventArgs> action) =>
        control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h);
}