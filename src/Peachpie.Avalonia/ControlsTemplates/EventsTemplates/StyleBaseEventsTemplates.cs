using System;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class StyleBaseEventsTemplates
{
    public static PhpValue OnOwnerChanged(StyleBase control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.OwnerChanged += h));
}