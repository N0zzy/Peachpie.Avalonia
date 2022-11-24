using System;
using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class TemplatedControlEventsExtension
{
    public static TemplatedControl
        OnTemplateApplied(TemplatedControl control, Action<TemplateAppliedEventArgs> action) =>
        control._setEvent((EventHandler<TemplateAppliedEventArgs>)((_, args) => action(args)),
            h => control.TemplateApplied += h);
}