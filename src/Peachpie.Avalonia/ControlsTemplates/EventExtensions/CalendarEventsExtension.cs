using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class CalendarEventsExtension
{
    public static Calendar OnSelectedDatesChanged(Calendar control, Action<SelectionChangedEventArgs> action) =>
        control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectedDatesChanged += h);

    public static Calendar OnDisplayDateChanged(Calendar control, Action<CalendarDateChangedEventArgs> action) =>
        control._setEvent((EventHandler<CalendarDateChangedEventArgs>)((_, args) => action(args)),
            h => control.DisplayDateChanged += h);

    public static Calendar OnDisplayModeChanged(Calendar control, Action<CalendarModeChangedEventArgs> action) =>
        control._setEvent((EventHandler<CalendarModeChangedEventArgs>)((_, args) => action(args)),
            h => control.DisplayModeChanged += h);
}