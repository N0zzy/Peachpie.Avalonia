using System;
using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ScrollBarEventsExtension
{
    public static ScrollBar OnScroll(ScrollBar control, Action<ScrollEventArgs> action) =>
        control._setEvent((EventHandler<ScrollEventArgs>)((_, args) => action(args)), h => control.Scroll += h);
}