using System;
using Avalonia.Media;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ExperimentalAcrylicMaterialEventsExtension
{
    public static ExperimentalAcrylicMaterial OnInvalidated(ExperimentalAcrylicMaterial control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h);
}