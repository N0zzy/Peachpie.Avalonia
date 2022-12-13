<?php
namespace SharPie\EventsTemplates;

use Closure;
use SharPie\Controls\UxButton;
use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\ButtonEventsTemplates;

trait UxButtonEventsTemplates
{
    public function on_Click(Closure $callback) : UxButton
    {
        return ButtonEventsTemplates::OnClick($this, $callback);
    }
}