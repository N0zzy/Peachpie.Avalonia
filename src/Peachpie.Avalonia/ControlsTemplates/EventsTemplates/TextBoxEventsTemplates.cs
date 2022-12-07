using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class TextBoxEventsTemplates
{
    public static PhpValue OnCopyingToClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.CopyingToClipboard += h));

    public static PhpValue OnCuttingToClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.CuttingToClipboard += h));

    public static PhpValue OnPastingFromClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.PastingFromClipboard += h));

    public static PhpValue OnTextChanged(TextBox control, Action<TextChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TextChangedEventArgs>)((_, args) => action(args)),
            h => control.TextChanged += h));

    public static PhpValue OnTextChanging(TextBox control, Action<TextChangingEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TextChangingEventArgs>)((_, args) => action(args)),
            h => control.TextChanging += h));
}