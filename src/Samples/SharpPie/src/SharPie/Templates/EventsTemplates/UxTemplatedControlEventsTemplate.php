<?php

namespace SharPie\Templates\EventsTemplates;

use Closure;
use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\TemplatedControlEventsTemplate;
use SharPie\Controls\Primitives\UxTemplatedControl;

trait UxTemplatedControlEventsTemplate
{
    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_TemplateApplied( Closure $callback) {
        return TemplatedControlEventsTemplate::OnTemplateApplied($this, $callback);
    }
}