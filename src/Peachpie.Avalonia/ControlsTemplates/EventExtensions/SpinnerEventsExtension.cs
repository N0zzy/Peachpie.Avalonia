using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class SpinnerEventsExtension
{
    public static Spinner OnSpin(Spinner control, Action<SpinEventArgs> action) =>
        control._setEvent((EventHandler<SpinEventArgs>)((_, args) => action(args)), h => control.Spin += h);
}