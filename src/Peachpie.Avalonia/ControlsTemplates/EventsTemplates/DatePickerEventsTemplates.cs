using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class DatePickerEventsTemplates
{
    public static PhpValue OnSelectedDateChanged(DatePicker control,
        Action<DatePickerSelectedValueChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<DatePickerSelectedValueChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDateChanged += h));
}