using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class TimePickerEventsTemplates
{
    public static PhpValue OnSelectedTimeChanged(TimePicker control,
        Action<TimePickerSelectedValueChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<TimePickerSelectedValueChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedTimeChanged += h));
}