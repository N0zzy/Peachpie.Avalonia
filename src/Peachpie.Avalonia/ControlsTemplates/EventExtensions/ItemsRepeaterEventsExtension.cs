using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ItemsRepeaterEventsExtension
{
    public static ItemsRepeater OnElementClearing(ItemsRepeater control,
        Action<ItemsRepeaterElementClearingEventArgs> action) =>
        control._setEvent((EventHandler<ItemsRepeaterElementClearingEventArgs>)((_, args) => action(args)),
            h => control.ElementClearing += h);

    public static ItemsRepeater OnElementIndexChanged(ItemsRepeater control,
        Action<ItemsRepeaterElementIndexChangedEventArgs> action) =>
        control._setEvent((EventHandler<ItemsRepeaterElementIndexChangedEventArgs>)((_, args) => action(args)),
            h => control.ElementIndexChanged += h);

    public static ItemsRepeater OnElementPrepared(ItemsRepeater control,
        Action<ItemsRepeaterElementPreparedEventArgs> action) =>
        control._setEvent((EventHandler<ItemsRepeaterElementPreparedEventArgs>)((_, args) => action(args)),
            h => control.ElementPrepared += h);
}