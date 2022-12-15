<?php

namespace SharPie\Controls;

use Peachpie\Avalonia\ControlsTemplates\ButtonTemplate;

use SharPie\EventsTemplates\UxButtonEventsTemplates;
use SharPie\EventsTemplates\UxControlEventsTemplate;
use SharPie\Input\UxInputElementTemplate;


class UxButton extends ButtonTemplate {
    use UxInputElementTemplate;
    use UxButtonEventsTemplates;

    use UxControlEventsTemplate;
}