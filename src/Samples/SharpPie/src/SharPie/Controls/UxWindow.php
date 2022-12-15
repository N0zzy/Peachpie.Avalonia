<?php

namespace SharPie\Controls;

use Peachpie\Avalonia\ControlsTemplates\WindowTemplate;
use SharPie\Templates\EventsTemplates\UxControlEventsTemplate;
use SharPie\Templates\UxInputElementTemplate;


class UxWindow extends WindowTemplate {
    use UxInputElementTemplate;
    use UxControlEventsTemplate;
}