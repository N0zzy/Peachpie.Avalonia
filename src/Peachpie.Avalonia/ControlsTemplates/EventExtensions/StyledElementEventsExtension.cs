using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.LogicalTree;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class StyledElementEventsExtension
{
    public static StyledElement OnAttachedToLogicalTree(StyledElement control,
        Action<LogicalTreeAttachmentEventArgs> action) =>
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.AttachedToLogicalTree += h);

    public static StyledElement OnDetachedFromLogicalTree(StyledElement control,
        Action<LogicalTreeAttachmentEventArgs> action) =>
        control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.DetachedFromLogicalTree += h);

    public static StyledElement OnDataContextChanged(StyledElement control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.DataContextChanged += h);

    public static StyledElement OnInitialized(StyledElement control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Initialized += h);

    public static StyledElement OnResourcesChanged(StyledElement control, Action<ResourcesChangedEventArgs> action) =>
        control._setEvent((EventHandler<ResourcesChangedEventArgs>)((_, args) => action(args)),
            h => control.ResourcesChanged += h);
}