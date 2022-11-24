using System;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class TreeViewEventsExtension
{
    public static TreeView OnSelectionChanged(TreeView control, Action<SelectionChangedEventArgs> action) =>
        control._setEvent((EventHandler<SelectionChangedEventArgs>)((_, args) => action(args)),
            h => control.SelectionChanged += h);
}