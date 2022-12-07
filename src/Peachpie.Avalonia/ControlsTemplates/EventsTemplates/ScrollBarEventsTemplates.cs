using System;
using Avalonia.Controls.Primitives;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ScrollBarEventsTemplates
{
    public static PhpValue OnScroll(ScrollBar control, Action<ScrollEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ScrollEventArgs>)((_, args) => action(args)),
            h => control.Scroll += h));
}