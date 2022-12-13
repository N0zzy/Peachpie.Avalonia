<?php

namespace SharPie\Controls;

use Peachpie\Avalonia\ControlsTemplates\ButtonTemplate;
use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\ButtonEventsTemplates;

use Closure;

trait UxButtonEventsTemplates 
{
    public function on_Click(Closure $callback) : UxButton
    {
        return ButtonEventsTemplates::OnClick($this, $callback);
    }
}


class UxButton extends ButtonTemplate {
    use UxButtonEventsTemplates;
}