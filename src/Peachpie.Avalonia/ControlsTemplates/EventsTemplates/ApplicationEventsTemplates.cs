using Avalonia;
using Avalonia.Controls;
using Pchp.Core;
using System;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class ApplicationEventsTemplates
{
    public static PhpValue OnResourcesChanged(ApplicationTemplates control, Action<ResourcesChangedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<ResourcesChangedEventArgs>)((_, args) => action(args)),
            h => control.ResourcesChanged += h));

    public static PhpValue OnUrlsOpened(ApplicationTemplates control, Action<UrlOpenedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<UrlOpenedEventArgs>)((_, args) => action(args)),
            h => control.UrlsOpened += h));
}