using System;
using Avalonia.Controls.Primitives;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class PickerPresenterBaseEventsTemplates
{
    public static PhpValue OnConfirmed(PickerPresenterBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Confirmed += h));

    public static PhpValue OnDismissed(PickerPresenterBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Dismissed += h));
}