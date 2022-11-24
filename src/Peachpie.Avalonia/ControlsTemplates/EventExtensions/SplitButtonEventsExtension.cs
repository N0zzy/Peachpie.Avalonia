using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class SplitButtonEventsExtension
{
    public static SplitButton OnClick(SplitButton control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)), h => control.Click += h);
}