using System;
using Avalonia.Controls.Primitives;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class TemplatedControlEventsTemplate
{
    public static PhpValue OnTemplateApplied(TemplatedControl control, Action<TemplateAppliedEventArgs> action)
    {
        return PhpValue.FromClass(control._setEvent(
            (EventHandler<TemplateAppliedEventArgs>) ((_, args) => action(args)),
            h => control.TemplateApplied += h));
    }
}