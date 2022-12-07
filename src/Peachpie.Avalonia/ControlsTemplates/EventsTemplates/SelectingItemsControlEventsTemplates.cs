using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class SelectingItemsControlEventsTemplates
{
    public static PhpValue
        OnSelectionChanged(SelectingItemsControl control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h));
}