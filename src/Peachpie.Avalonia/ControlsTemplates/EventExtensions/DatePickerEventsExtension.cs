using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class DatePickerEventsExtension
{
    public static DatePicker OnSelectedDateChanged(DatePicker control,
        Action<DatePickerSelectedValueChangedEventArgs> action) =>
        control._setEvent((EventHandler<DatePickerSelectedValueChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDateChanged += h);
}