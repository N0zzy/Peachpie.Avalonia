<?php

namespace SharPie\Input;

use SharPie\EventsTemplates\UxInputElementEventsTemplate;
use SharPie\PropertyTemplates\UxInputElementPropertyTemplate;

trait UxInputElementTemplate
{
    use UxInputElementPropertyTemplate;
    use UxInputElementEventsTemplate;
}