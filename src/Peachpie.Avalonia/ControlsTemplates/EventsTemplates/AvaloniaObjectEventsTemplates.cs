using System;
using Avalonia;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class AvaloniaObjectEventsTemplates
{
    public static PhpValue OnPropertyChanged(AvaloniaObject control, Action<AvaloniaPropertyChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<AvaloniaPropertyChangedEventArgs>)((_, args) => action(args)),
            h => control.PropertyChanged += h));
}