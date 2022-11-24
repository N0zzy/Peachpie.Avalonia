// using System;
// using Avalonia.Interactivity;
//
// namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;
//
// public class RichTextBlockEventsExtension
// {
//     public static RichTextBlock OnCopyingToClipboard(RichTextBlock control, Action<RoutedEventArgs> action) => 
//          control._setEvent((EventHandler<RoutedEventArgs>) ((_, args) => action(args)), h => control.CopyingToClipboard += h);
// }