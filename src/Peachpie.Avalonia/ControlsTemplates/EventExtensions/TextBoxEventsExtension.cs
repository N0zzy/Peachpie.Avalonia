using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class TextBoxEventsExtension
{
    public static TextBox OnCopyingToClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.CopyingToClipboard += h);

    public static TextBox OnCuttingToClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.CuttingToClipboard += h);

    public static TextBox OnPastingFromClipboard(TextBox control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.PastingFromClipboard += h);

    public static TextBox OnTextChanged(TextBox control, Action<TextChangedEventArgs> action) =>
        control._setEvent((EventHandler<TextChangedEventArgs>)((_, args) => action(args)),
            h => control.TextChanged += h);

    public static TextBox OnTextChanging(TextBox control, Action<TextChangingEventArgs> action) =>
        control._setEvent((EventHandler<TextChangingEventArgs>)((_, args) => action(args)),
            h => control.TextChanging += h);
}