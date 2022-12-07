using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class SelectableTextBlockEventsTemplates
{
    public static PhpValue OnCopyingToClipboard(SelectableTextBlock control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.CopyingToClipboard += h));
}