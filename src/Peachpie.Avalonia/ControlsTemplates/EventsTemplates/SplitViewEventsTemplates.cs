using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class SplitViewEventsTemplates
{
    public static PhpValue OnPaneClosed(SplitView control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.PaneClosed += h));

    public static PhpValue OnPaneClosing(SplitView control, Action<SplitViewPaneClosingEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SplitViewPaneClosingEventArgs>)((_, args) => action(args)),
            h => control.PaneClosing += h));

    public static PhpValue OnPaneOpened(SplitView control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.PaneOpened += h));

    public static PhpValue OnPaneOpening(SplitView control, Action<EventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<EventArgs>)((_, args) => action(args)),
            h => control.PaneOpening += h));
}