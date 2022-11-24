using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class NativeMenuEventsExtension
{
    public static NativeMenu OnNeedsUpdate(NativeMenu control, Action<EventArgs> action) =>
        control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)), h => control.NeedsUpdate += h);

    public static NativeMenu OnOpening(NativeMenu control, Action<EventArgs> action) =>
        control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)), h => control.Opening += h);

    public static NativeMenu OnClosed(NativeMenu control, Action<EventArgs> action) =>
        control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)), h => control.Closed += h);
}