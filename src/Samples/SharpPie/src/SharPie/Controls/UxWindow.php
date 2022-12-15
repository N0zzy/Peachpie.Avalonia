<?php

namespace SharPie\Controls;

use Peachpie\Avalonia\ControlsTemplates\WindowTemplate;
use SharPie\EventsTemplates\UxControlEventsTemplate;
use SharPie\Input\UxInputElementTemplate;

class UxWindow extends WindowTemplate {
    use UxInputElementTemplate;
    use UxControlEventsTemplate;
}