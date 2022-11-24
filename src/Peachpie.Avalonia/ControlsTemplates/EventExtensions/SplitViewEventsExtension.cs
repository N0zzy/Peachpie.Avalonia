using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class SplitViewEventsExtension
{
    public static SplitView OnPaneClosed(SplitView control, Action<EventArgs> action) =>
        control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)), h => control.PaneClosed += h);

    public static SplitView OnPaneClosing(SplitView control, Action<SplitViewPaneClosingEventArgs> action) =>
        control._setEvent((EventHandler<SplitViewPaneClosingEventArgs>)((_, args) => action(args)),
            h => control.PaneClosing += h);

    public static SplitView OnPaneOpened(SplitView control, Action<EventArgs> action) =>
        control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)), h => control.PaneOpened += h);

    public static SplitView OnPaneOpening(SplitView control, Action<EventArgs> action) =>
        control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)), h => control.PaneOpening += h);
}