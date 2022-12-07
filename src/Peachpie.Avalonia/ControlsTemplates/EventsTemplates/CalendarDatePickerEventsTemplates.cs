using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class CalendarDatePickerEventsTemplates
{
    public static PhpValue OnCalendarClosed(CalendarDatePickerTemplate control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.CalendarClosed += h));

    public static PhpValue OnCalendarOpened(CalendarDatePickerTemplate control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.CalendarOpened += h));

    public static PhpValue OnDateValidationError(CalendarDatePickerTemplate control,
        Action<CalendarDatePickerDateValidationErrorEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<CalendarDatePickerDateValidationErrorEventArgs>)((_, args) => action(args)),
            h => control.DateValidationError += h));

    public static PhpValue OnSelectedDateChanged(CalendarDatePickerTemplate control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDateChanged += h));
}