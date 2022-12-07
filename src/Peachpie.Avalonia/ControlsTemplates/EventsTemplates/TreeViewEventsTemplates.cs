using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class TreeViewEventsTemplates
{
    public static PhpValue OnSelectionChanged(TreeView control, Action<SelectionChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h));
}