using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class SelectingItemsControlEventsExtension
{
    public static SelectingItemsControl OnSelectionChanged(SelectingItemsControl control,
        Action<SelectionChangedEventArgs> action) =>
        control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h);
}