using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class NumericUpDownEventsTemplates
{
    public static PhpValue OnSpinned(NumericUpDown control, Action<SpinEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SpinEventArgs>)((_, args) => action(args)),
            h => control.Spinned += h));

    public static PhpValue OnValueChanged(NumericUpDown control, Action<NumericUpDownValueChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<NumericUpDownValueChangedEventArgs>)((_, args) => action(args)),
            h => control.ValueChanged += h));
}