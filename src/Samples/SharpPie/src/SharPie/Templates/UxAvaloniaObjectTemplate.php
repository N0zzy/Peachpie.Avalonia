<?php

namespace SharPie\Templates;

use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\AvaloniaObjectEventsTemplate;
use Closure;

trait UxAvaloniaObjectTemplate
{
    #Events
    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_PropertyChanged(Closure $callback)
    {
        return AvaloniaObjectEventsTemplate::OnPropertyChanged($this, $callback);
    }

    #Fields

}