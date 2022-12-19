using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.LogicalTree;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class StyledElementEventsTemplate
{
    public static PhpValue OnAttachedToLogicalTree(StyledElement control, Action<LogicalTreeAttachmentEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.AttachedToLogicalTree += h));

    public static PhpValue OnDetachedFromLogicalTree(StyledElement control,
        Action<LogicalTreeAttachmentEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<LogicalTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.DetachedFromLogicalTree += h));

    public static PhpValue OnDataContextChanged(StyledElement control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.DataContextChanged += h));

    public static PhpValue OnInitialized(StyledElement control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Initialized += h));

    public static PhpValue OnResourcesChanged(StyledElement control, Action<ResourcesChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ResourcesChangedEventArgs>)((_, args) => action(args)),
            h => control.ResourcesChanged += h));
}