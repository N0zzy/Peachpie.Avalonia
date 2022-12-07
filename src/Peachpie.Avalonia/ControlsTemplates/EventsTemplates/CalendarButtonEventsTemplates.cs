using System;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class CalendarButtonEventsTemplates
{
    public static PhpValue
        OnCalendarLeftMouseButtonDown(CalendarButton control, Action<PointerPressedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerPressedEventArgs>)((_, args) => action(args)),
            h => control.CalendarLeftMouseButtonDown += h));

    public static PhpValue
        OnCalendarLeftMouseButtonUp(CalendarButton control, Action<PointerReleasedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerReleasedEventArgs>)((_, args) => action(args)),
            h => control.CalendarLeftMouseButtonUp += h));
}