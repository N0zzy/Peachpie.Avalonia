using System;
using System.ComponentModel;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class AutoCompleteBoxEventsTemplates
{
    public static PhpValue OnTextChanged(AutoCompleteBoxTemplates control, Action<TextChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TextChangedEventArgs>)((_, args) => action(args)),
            h => control.TextChanged += h));

    public static PhpValue OnPopulating(AutoCompleteBoxTemplates control, Action<PopulatingEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PopulatingEventArgs>)((_, args) => action(args)),
            h => control.Populating += h));

    public static PhpValue OnPopulated(AutoCompleteBoxTemplates control, Action<PopulatedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PopulatedEventArgs>)((_, args) => action(args)),
            h => control.Populated += h));

    public static PhpValue OnDropDownOpening(AutoCompleteBoxTemplates control, Action<CancelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.DropDownOpening += h));

    public static PhpValue OnDropDownOpened(AutoCompleteBoxTemplates control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.DropDownOpened += h));

    public static PhpValue OnDropDownClosing(AutoCompleteBoxTemplates control, Action<CancelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.DropDownClosing += h));

    public static PhpValue OnDropDownClosed(AutoCompleteBoxTemplates control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.DropDownClosed += h));

    public static PhpValue OnSelectionChanged(AutoCompleteBoxTemplates control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h));
}