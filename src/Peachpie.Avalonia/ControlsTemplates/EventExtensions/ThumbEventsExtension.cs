using System;
using Avalonia.Controls.Primitives;
using Avalonia.Input;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ThumbEventsExtension
{
    public static Thumb OnDragStarted(Thumb control, Action<VectorEventArgs> action) =>
        control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)), h => control.DragStarted += h);

    public static Thumb OnDragDelta(Thumb control, Action<VectorEventArgs> action) =>
        control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)), h => control.DragDelta += h);

    public static Thumb OnDragCompleted(Thumb control, Action<VectorEventArgs> action) =>
        control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)), h => control.DragCompleted += h);
}