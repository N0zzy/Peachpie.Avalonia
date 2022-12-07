using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ScrollViewerEventsTemplates
{
    public static PhpValue OnScrollChanged(ScrollViewer control, Action<ScrollChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ScrollChangedEventArgs>)((_, args) => action(args)),
            h => control.ScrollChanged += h));
}