using System;
using Avalonia.Controls.Notifications;
using Avalonia.Interactivity;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class NotificationCardEventExtension
{
    public static NotificationCard OnNotificationClosed(NotificationCard control, Action<RoutedEventArgs> action) =>
        control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.NotificationClosed += h);
}