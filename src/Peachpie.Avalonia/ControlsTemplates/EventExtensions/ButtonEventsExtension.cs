using System;
using Avalonia;
using Avalonia.Controls;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class ButtonEventsExtension
{
    public static Application OnResourcesChanged(Application control, Action<ResourcesChangedEventArgs> action) =>
        control._setEvent((EventHandler<ResourcesChangedEventArgs>)((_, args) => action(args)),
            h => control.ResourcesChanged += h);

    public static Application OnUrlsOpened(Application control, Action<UrlOpenedEventArgs> action) =>
        control._setEvent((EventHandler<UrlOpenedEventArgs>)((_, args) => action(args)), h => control.UrlsOpened += h);
}