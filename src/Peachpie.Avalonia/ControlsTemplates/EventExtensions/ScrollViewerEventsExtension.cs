using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ScrollViewerEventsExtension
{
    public static ScrollViewer OnScrollChanged(ScrollViewer control, Action<ScrollChangedEventArgs> action) =>
        control._setEvent((EventHandler<ScrollChangedEventArgs>)((_, args) => action(args)),
            h => control.ScrollChanged += h);
}