using System;
using Avalonia;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class VisualEventsExtension
{
    public static Visual OnAttachedToVisualTree(Visual control, Action<VisualTreeAttachmentEventArgs> action) =>
        control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.AttachedToVisualTree += h);

    public static Visual OnDetachedFromVisualTree(Visual control, Action<VisualTreeAttachmentEventArgs> action) =>
        control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.DetachedFromVisualTree += h);
}