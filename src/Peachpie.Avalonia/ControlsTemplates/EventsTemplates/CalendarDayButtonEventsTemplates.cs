using System;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class CalendarDayButtonEventsTemplates
{
    public static PhpValue OnCalendarDayButtonMouseDown(CalendarDayButton control,
        Action<PointerPressedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerPressedEventArgs>)((_, args) => action(args)),
            h => control.CalendarDayButtonMouseDown += h));

    public static PhpValue OnCalendarDayButtonMouseUp(CalendarDayButton control,
        Action<PointerReleasedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerReleasedEventArgs>)((_, args) => action(args)),
            h => control.CalendarDayButtonMouseUp += h));
}