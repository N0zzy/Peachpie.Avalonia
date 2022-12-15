<?php

namespace SharPie\Templates\EventsTemplates;

use Closure;
use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\ControlEventsTemplate;
use SharPie\Controls\UxControl;

trait UxControlEventsTemplate
{
    /**
     * Occurs when the user has completed a context input gesture, such as a right-click.
     * @param Closure $callback
     * @return $this
     */
    public function on_ContextRequested(Closure $callback) {
        return ControlEventsTemplate::OnContextRequested($this, $callback);
    }

    /**
     * Occurs when the control has been fully constructed in the visual tree and both
     * layout and render are complete.
     * @param Closure $callback
     * @return $this
     */
    public function on_Loaded(Closure $callback) {
        return ControlEventsTemplate::OnLoaded($this, $callback);
    }

    /**
     * Occurs when the control is removed from the visual tree.
     * @param Closure $callback
     * @return $this
     */
    public function on_Unloaded(Closure $callback) {
        return ControlEventsTemplate::OnUnloaded($this, $callback);
    }

    /**
     * Occurs when the bounds (actual size) of the control have changed.
     * @param Closure $callback
     * @return $this
     */
    public function on_SizeChanged(Closure $callback) {
        return ControlEventsTemplate::OnSizeChanged($this, $callback);
    }
}