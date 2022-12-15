<?php

namespace SharPie\Templates\EventsTemplates;

use Closure;
use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\InputElementEventsTemplate;
use SharPie\Input\UxInputElement;

trait UxInputElementEventsTemplate
{
    /**
     * Occurs when the control receives focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_GotFocus(Closure $callback): object {
        return InputElementEventsTemplate::OnGotFocus($this, $callback);
    }

    /**
     * Occurs when the control receives focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_LostFocus(Closure $callback): object
    {
        return InputElementEventsTemplate::OnLostFocus($this, $callback);
    }

    /**
     * Occurs when a key is pressed while the control has focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_KeyDown(Closure $callback): object
    {
        return InputElementEventsTemplate::OnKeyDown($this, $callback);
    }

    /**
     * Occurs when a key is released while the control has focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_KeyUp(Closure $callback): object
    {
        return InputElementEventsTemplate::OnKeyUp($this, $callback);
    }

    /**
     * Occurs when a user typed some text while the control has focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_TextInput(Closure $callback): object
    {
        return InputElementEventsTemplate::OnTextInput($this, $callback);
    }

    /**
     * Occurs when an input element gains input focus and input method is looking for the corresponding client
     * @param Closure $callback
     * @return $this
     */
    public function on_TextInputMethodClientRequested(Closure $callback): object
    {
        return InputElementEventsTemplate::OnTextInputMethodClientRequested($this, $callback);
    }

    /**
     * Occurs when the pointer enters the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerEntered(Closure $callback)
    {
        return InputElementEventsTemplate::OnPointerEntered($this, $callback);
    }

    /**
     * Occurs when the pointer leaves the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerExited(Closure $callback): object
    {
        return InputElementEventsTemplate::OnPointerExited($this, $callback);
    }

    /**
     * Occurs when the pointer moves over the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerMoved(Closure $callback): object
    {
        return InputElementEventsTemplate::OnPointerMoved($this, $callback);
    }

    /**
     * Occurs when the pointer is pressed over the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerPressed(Closure $callback): object
    {
        return InputElementEventsTemplate::OnPointerPressed($this, $callback);
    }

    /**
     * Occurs when the pointer is released over the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerReleased(Closure $callback): object
    {
        return InputElementEventsTemplate::OnPointerReleased($this, $callback);
    }

    /**
     * Occurs when the control or its child control loses the pointer capture for any reason,
     * event will not be triggered for a parent control if capture was transferred to another
     * child of that parent control
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerCaptureLost(Closure $callback): object
    {
        return InputElementEventsTemplate::OnPointerCaptureLost($this, $callback);
    }

    /**
     * Occurs when the mouse is scrolled over the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerWheelChanged(Closure $callback): object
    {
        return InputElementEventsTemplate::OnPointerWheelChanged($this, $callback);
    }

    /**
     * Occurs when a tap gesture occurs on the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_Tapped(Closure $callback): object
    {
        return InputElementEventsTemplate::OnTapped($this, $callback);
    }

    /**
     * Occurs when a double-tap gesture occurs on the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_DoubleTapped(Closure $callback): object
    {
        return InputElementEventsTemplate::OnDoubleTapped($this, $callback);
    }
}