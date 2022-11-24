using System;
using Avalonia.Controls.Primitives;
using Avalonia.Input;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class CalendarButtonEventsExtension
{
    public static CalendarButton OnCalendarLeftMouseButtonDown(CalendarButton control,
        Action<PointerPressedEventArgs> action) =>
        control._setEvent((EventHandler<PointerPressedEventArgs>)((_, args) => action(args)),
            h => control.CalendarLeftMouseButtonDown += h);

    public static CalendarButton OnCalendarLeftMouseButtonUp(CalendarButton control,
        Action<PointerReleasedEventArgs> action) =>
        control._setEvent((EventHandler<PointerReleasedEventArgs>)((_, args) => action(args)),
            h => control.CalendarLeftMouseButtonUp += h);
}