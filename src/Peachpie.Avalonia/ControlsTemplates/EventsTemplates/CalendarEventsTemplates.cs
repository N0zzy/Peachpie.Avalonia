using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class CalendarEventsTemplates
{
    public static PhpValue OnSelectedDatesChanged(Calendar control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDatesChanged += h));

    public static PhpValue OnDisplayDateChanged(Calendar control, Action<CalendarDateChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CalendarDateChangedEventArgs>)((_, args) => action(args)),
            h => control.DisplayDateChanged += h));

    public static PhpValue OnDisplayModeChanged(Calendar control, Action<CalendarModeChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CalendarModeChangedEventArgs>)((_, args) => action(args)),
            h => control.DisplayModeChanged += h));
}