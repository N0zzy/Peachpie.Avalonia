using System;
using Avalonia.Input;
using Avalonia.Input.TextInput;
using Avalonia.Interactivity;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class InputElementEventsTemplate
{
    public static PhpValue OnGotFocus(InputElement control, Action<GotFocusEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<GotFocusEventArgs>)((_, args) => action(args)),
            h => control.GotFocus += h));

    public static PhpValue OnLostFocus(InputElement control, Action<RoutedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<RoutedEventArgs>)((_, args) => action(args)),
            h => control.LostFocus += h));

    public static PhpValue OnKeyDown(InputElement control, Action<KeyEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<KeyEventArgs>)((_, args) => action(args)),
            h => control.KeyDown += h));

    public static PhpValue OnKeyUp(InputElement control, Action<KeyEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<KeyEventArgs>)((_, args) => action(args)),
            h => control.KeyUp += h));

    public static PhpValue OnTextInput(InputElement control, Action<TextInputEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TextInputEventArgs>)((_, args) => action(args)),
            h => control.TextInput += h));

    public static PhpValue OnTextInputMethodClientRequested(InputElement control,
        Action<TextInputMethodClientRequestedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent(
            (EventHandler<TextInputMethodClientRequestedEventArgs>)((_, args) => action(args)),
            h => control.TextInputMethodClientRequested += h));

    public static PhpValue OnPointerEntered(InputElement control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerEntered += h));

    public static PhpValue OnPointerExited(InputElement control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerExited += h));

    public static PhpValue OnPointerMoved(InputElement control, Action<PointerEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerEventArgs>)((_, args) => action(args)),
            h => control.PointerMoved += h));

    public static PhpValue OnPointerPressed(InputElement control, Action<PointerPressedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerPressedEventArgs>)((_, args) => action(args)),
            h => control.PointerPressed += h));

    public static PhpValue OnPointerReleased(InputElement control, Action<PointerReleasedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerReleasedEventArgs>)((_, args) => action(args)),
            h => control.PointerReleased += h));

    public static PhpValue OnPointerCaptureLost(InputElement control, Action<PointerCaptureLostEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerCaptureLostEventArgs>)((_, args) => action(args)),
            h => control.PointerCaptureLost += h));

    public static PhpValue OnPointerWheelChanged(InputElement control, Action<PointerWheelEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<PointerWheelEventArgs>)((_, args) => action(args)),
            h => control.PointerWheelChanged += h));

    public static PhpValue OnTapped(InputElement control, Action<TappedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TappedEventArgs>)((_, args) => action(args)),
            h => control.Tapped += h));

    public static PhpValue OnDoubleTapped(InputElement control, Action<TappedEventArgs> action) =>
        PhpValue.FromClass(control._setEvent((EventHandler<TappedEventArgs>)((_, args) => action(args)),
            h => control.DoubleTapped += h));
}