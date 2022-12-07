using System;
using Avalonia.Controls.Notifications;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class NotificationCardEventsTemplates
{
    public static PhpValue OnNotificationClosed(NotificationCard control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.NotificationClosed += h));
}