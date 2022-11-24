using System;
using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class DateTimePickerPanelEventsExtension
{
    public static DateTimePickerPanel OnScrollInvalidated(DateTimePickerPanel control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.ScrollInvalidated += h);

    public static DateTimePickerPanel OnSelectionChanged(DateTimePickerPanel control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.SelectionChanged += h);
}