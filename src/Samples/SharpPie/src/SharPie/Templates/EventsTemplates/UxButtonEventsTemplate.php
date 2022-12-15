<?php
namespace SharPie\Templates\EventsTemplates;

use Closure;
use SharPie\Controls\UxButton;
use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\ButtonEventsTemplates;

trait UxButtonEventsTemplate
{
    /**
     * @param Closure $callback
     * @return UxButton
     */
    public function on_Click( Closure $callback) : UxButton
    {
        return ButtonEventsTemplates::OnClick($this, $callback);
    }
}