using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class NumericUpDownEventsExtension
{
    public static NumericUpDown OnSpinned(NumericUpDown control, Action<SpinEventArgs> action) =>
        control._setEvent((EventHandler<SpinEventArgs>)((_, args) => action(args)), h => control.Spinned += h);

    public static NumericUpDown
        OnValueChanged(NumericUpDown control, Action<NumericUpDownValueChangedEventArgs> action) =>
        control._setEvent((EventHandler<NumericUpDownValueChangedEventArgs>)((_, args) => action(args)),
            h => control.ValueChanged += h);
}