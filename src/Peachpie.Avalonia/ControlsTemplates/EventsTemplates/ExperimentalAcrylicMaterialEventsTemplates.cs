using System;
using Avalonia.Media;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ExperimentalAcrylicMaterialEventsTemplates
{
    public static PhpValue OnInvalidated(ExperimentalAcrylicMaterial control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h));
}