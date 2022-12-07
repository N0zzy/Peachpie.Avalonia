using System;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class SpinnerEventsTemplates
{
    public static PhpValue OnSpin(Spinner control, Action<SpinEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<SpinEventArgs>)((_, args) => action(args)),
            h => control.Spin += h));
}