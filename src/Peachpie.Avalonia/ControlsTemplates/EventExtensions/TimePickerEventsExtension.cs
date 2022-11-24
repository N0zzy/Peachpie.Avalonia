using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class TimePickerEventsExtension
{
    public static TimePicker OnSelectedTimeChanged(TimePicker control,
        Action<TimePickerSelectedValueChangedEventArgs> action) =>
        control._setEvent((EventHandler<TimePickerSelectedValueChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedTimeChanged += h);
}