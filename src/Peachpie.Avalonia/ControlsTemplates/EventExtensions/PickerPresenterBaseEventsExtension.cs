using System;
using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class PickerPresenterBaseEventsExtension
{
    public static PickerPresenterBase OnConfirmed(PickerPresenterBase control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Confirmed += h);

    public static PickerPresenterBase OnDismissed(PickerPresenterBase control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Dismissed += h);
}