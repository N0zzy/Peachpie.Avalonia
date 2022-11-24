using System;
using Avalonia.Styling;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class StyleBaseEventsExtension
{
    public static StyleBase OnOwnerChanged(StyleBase control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.OwnerChanged += h);
}