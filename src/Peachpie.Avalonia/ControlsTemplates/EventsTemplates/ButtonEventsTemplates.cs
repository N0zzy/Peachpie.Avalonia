using System;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ButtonEventsTemplates
{
    public static PhpValue OnClick(ButtonTemplate control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.Click += h));
}