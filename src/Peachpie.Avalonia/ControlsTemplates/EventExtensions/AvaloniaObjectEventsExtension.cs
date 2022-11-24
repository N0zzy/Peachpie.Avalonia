using System;
using Avalonia;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class AvaloniaObjectEventsExtension
{
    public static AvaloniaObject OnPropertyChanged(AvaloniaObject control,
        Action<AvaloniaPropertyChangedEventArgs> action) =>
        control._setEvent((EventHandler<AvaloniaPropertyChangedEventArgs>)((_, args) => action(args)),
            h => control.PropertyChanged += h);
}