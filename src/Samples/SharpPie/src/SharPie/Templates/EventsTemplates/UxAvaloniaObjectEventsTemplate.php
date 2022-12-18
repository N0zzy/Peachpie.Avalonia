<?php

namespace SharPie\Templates\EventsTemplates;

use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\AvaloniaObjectEventsTemplate;
use Closure;

trait UxAvaloniaObjectEventsTemplate
{
    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_PropertyChanged(Closure $callback)
    {
        return AvaloniaObjectEventsTemplate::OnPropertyChanged($this, $callback);
    }
}