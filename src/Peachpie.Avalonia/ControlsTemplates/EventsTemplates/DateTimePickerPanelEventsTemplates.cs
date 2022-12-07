using System;
using Avalonia.Controls.Primitives;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class DateTimePickerPanelEventsTemplates
{
    public static PhpValue OnScrollInvalidated(DateTimePickerPanel control, Action action) =>
        PhpValue.FromClass(
            control._setEvent((EventHandler)((_, args) => action()), h => control.ScrollInvalidated += h));

    public static PhpValue OnSelectionChanged(DateTimePickerPanel control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.SelectionChanged += h));
}