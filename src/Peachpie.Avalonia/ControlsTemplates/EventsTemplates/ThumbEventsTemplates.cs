using System;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ThumbEventsTemplates
{
    public static PhpValue OnDragStarted(Thumb control, Action<VectorEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)),
            h => control.DragStarted += h));

    public static PhpValue OnDragDelta(Thumb control, Action<VectorEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)),
            h => control.DragDelta += h));

    public static PhpValue OnDragCompleted(Thumb control, Action<VectorEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VectorEventArgs>)((_, args) => action(args)),
            h => control.DragCompleted += h));
}