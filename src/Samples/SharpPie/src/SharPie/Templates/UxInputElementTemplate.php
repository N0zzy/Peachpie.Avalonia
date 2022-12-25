<?php

namespace SharPie\Templates;

use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\InputElementEventsTemplate;
use Peachpie\Avalonia\ControlsTemplates\PropertyTemplates\InputElementPropertyTemplate;
use Closure;

trait UxInputElementTemplate
{
    use UxAvaloniaObjectTemplate;
    use UxAnimatableTemplate;
    use UxStyledElementTemplate;
    use UxVisualTemplate;
    use UxLayoutableTemplate;
    use UxInteractiveTemplate;

    #Events
    /**
     * Occurs when the control receives focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_GotFocus($callback): object {
        return InputElementEventsTemplate::OnGotFocus($this, $callback);
    }

    /**
     * Occurs when the control receives focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_LostFocus($callback): object
    {
        return InputElementEventsTemplate::OnLostFocus($this, $callback);
    }

    /**
     * Occurs when a key is pressed while the control has focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_KeyDown($callback): object
    {
        return InputElementEventsTemplate::OnKeyDown($this, $callback);
    }

    /**
     * Occurs when a key is released while the control has focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_KeyUp($callback): object
    {
        return InputElementEventsTemplate::OnKeyUp($this, $callback);
    }

    /**
     * Occurs when a user typed some text while the control has focus.
     * @param Closure $callback
     * @return $this
     */
    public function on_TextInput($callback): object
    {
        return InputElementEventsTemplate::OnTextInput($this, $callback);
    }

    /**
     * Occurs when an input element gains input focus and input method is looking for the corresponding client
     * @param Closure $callback
     * @return $this
     */
    public function on_TextInputMethodClientRequested($callback): object
    {
        return InputElementEventsTemplate::OnTextInputMethodClientRequested($this, $callback);
    }

    /**
     * Occurs when the pointer enters the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerEntered($callback)
    {
        return InputElementEventsTemplate::OnPointerEntered($this, $callback);
    }

    /**
     * Occurs when the pointer leaves the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerExited($callback): object
    {
        return InputElementEventsTemplate::OnPointerExited($this, $callback);
    }

    /**
     * Occurs when the pointer moves over the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerMoved($callback): object
    {
        return InputElementEventsTemplate::OnPointerMoved($this, $callback);
    }

    /**
     * Occurs when the pointer is pressed over the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerPressed($callback): object
    {
        return InputElementEventsTemplate::OnPointerPressed($this, $callback);
    }

    /**
     * Occurs when the pointer is released over the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerReleased($callback): object
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
    public function on_PointerCaptureLost($callback): object
    {
        return InputElementEventsTemplate::OnPointerCaptureLost($this, $callback);
    }

    /**
     * Occurs when the mouse is scrolled over the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_PointerWheelChanged($callback): object
    {
        return InputElementEventsTemplate::OnPointerWheelChanged($this, $callback);
    }

    /**
     * Occurs when a tap gesture occurs on the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_Tapped($callback): object
    {
        return InputElementEventsTemplate::OnTapped($this, $callback);
    }

    /**
     * Occurs when a double-tap gesture occurs on the control.
     * @param Closure $callback
     * @return $this
     */
    public function on_DoubleTapped($callback): object
    {
        return InputElementEventsTemplate::OnDoubleTapped($this, $callback);
    }

    #Fields

    /**
     * @param bool $value
     * @return $this
     */
    public function Focusable(bool $value): object
    {
        return InputElementPropertyTemplate::Focusable($this, $value);
    }

    /**
     * @param bool $value
     * @return $this
     */
    public function IsEnabled(bool $value): object
    {
        return InputElementPropertyTemplate::IsEnabled($this, $value);
    }

    /*
    public function Cursor(Cursor $value) : Object
    {
        return InputElementPropertyTemplate::Cursor($this, $value);
    }
    */

    /**
     * @param bool $value
     * @return $this
     */
    public function IsHitTestVisible(bool $value): object
    {
        return InputElementPropertyTemplate::IsHitTestVisible($this, $value);
    }

    /**
     * @param bool $value
     * @return $this
     */
    public function IsTabStop(bool $value): object
    {
        return InputElementPropertyTemplate::IsTabStop($this, $value);
    }

    /**
     * @param int $value
     * @return $this
     */
    public function TabIndex(int $value): object
    {
        return InputElementPropertyTemplate::TabIndex($this, $value);
    }
}