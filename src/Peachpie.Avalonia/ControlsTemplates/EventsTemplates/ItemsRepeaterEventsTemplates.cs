using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ItemsRepeaterEventsTemplates
{
    public static PhpValue OnElementClearing(ItemsRepeater control,
        Action<ItemsRepeaterElementClearingEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<ItemsRepeaterElementClearingEventArgs>)((_, args) => action(args)),
            h => control.ElementClearing += h));

    public static PhpValue OnElementIndexChanged(ItemsRepeater control,
        Action<ItemsRepeaterElementIndexChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<ItemsRepeaterElementIndexChangedEventArgs>)((_, args) => action(args)),
            h => control.ElementIndexChanged += h));

    public static PhpValue OnElementPrepared(ItemsRepeater control,
        Action<ItemsRepeaterElementPreparedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<ItemsRepeaterElementPreparedEventArgs>)((_, args) => action(args)),
            h => control.ElementPrepared += h));
}