using System;
using System.ComponentModel;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class WindowEventsTemplates
{
    public static PhpValue OnClosing(Window control, Action<CancelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)),
            h => control.Closing += h));
}