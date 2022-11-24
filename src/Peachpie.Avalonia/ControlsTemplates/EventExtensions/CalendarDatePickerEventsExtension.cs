using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public static class CalendarDatePickerEventsExtension
{
    public static CalendarDatePicker OnCalendarClosed(CalendarDatePicker control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.CalendarClosed += h);

    public static CalendarDatePicker OnCalendarOpened(CalendarDatePicker control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.CalendarOpened += h);

    public static CalendarDatePicker OnDateValidationError(CalendarDatePicker control,
        Action<CalendarDatePickerDateValidationErrorEventArgs> action) =>
        control._setEvent((EventHandler<CalendarDatePickerDateValidationErrorEventArgs>)((_, args) => action(args)),
            h => control.DateValidationError += h);

    public static CalendarDatePicker OnSelectedDateChanged(CalendarDatePicker control,
        Action<SelectionChangedEventArgs> action) =>
        control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDateChanged += h);
}