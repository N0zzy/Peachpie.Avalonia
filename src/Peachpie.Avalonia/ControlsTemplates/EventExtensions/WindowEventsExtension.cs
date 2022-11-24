using System;
using System.ComponentModel;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class WindowEventsExtension
{
    public static Window OnClosing(Window control, Action<CancelEventArgs> action) =>
        control._setEvent((EventHandler<CancelEventArgs>)((_, args) => action(args)), h => control.Closing += h);
}