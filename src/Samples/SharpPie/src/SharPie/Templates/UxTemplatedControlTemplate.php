<?php

namespace SharPie\Templates;

use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\TemplatedControlEventsTemplate;
use Closure;

trait UxTemplatedControlTemplate
{
    #Events

    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_TemplateApplied($callback) {
        return TemplatedControlEventsTemplate::OnTemplateApplied($this, $callback);
    }
}