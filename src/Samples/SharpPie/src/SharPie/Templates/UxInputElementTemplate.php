<?php

namespace SharPie\Templates;

use SharPie\Templates\EventsTemplates\UxInputElementEventsTemplate;
use SharPie\Templates\PropertyTemplates\UxInputElementPropertyTemplate;

trait UxInputElementTemplate
{
    use UxInputElementPropertyTemplate;
    use UxInputElementEventsTemplate;
}