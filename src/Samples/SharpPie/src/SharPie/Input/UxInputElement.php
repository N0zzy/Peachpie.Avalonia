<?php

namespace SharPie\Input;

use SharPie\EventsTemplates\UxInputElementEventsTemplate;
use SharPie\PropertyTemplates\UxInputElementPropertyTemplate;

class UxInputElement
{
    use UxInputElementPropertyTemplate;
    use UxInputElementEventsTemplate;
}