using System;
using Avalonia;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class VisualEventsTemplate
{
    public static PhpValue OnAttachedToVisualTree(Visual control, Action<VisualTreeAttachmentEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.AttachedToVisualTree += h));

    public static PhpValue OnDetachedFromVisualTree(Visual control, Action<VisualTreeAttachmentEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<VisualTreeAttachmentEventArgs>)((_, args) => action(args)),
            h => control.DetachedFromVisualTree += h));
}