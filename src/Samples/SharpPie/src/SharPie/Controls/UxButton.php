<?php

namespace SharPie\Controls;

use Peachpie\Avalonia\ControlsTemplates\ButtonTemplate;

use SharPie\Templates\EventsTemplates\UxButtonEventsTemplate;
use SharPie\Templates\EventsTemplates\UxTemplatedControlEventsTemplate;
use SharPie\Templates\UxControlTemplate;
use SharPie\Templates\UxInputElementTemplate;

/**
 * AvaloniaObject
 * Animatable
 * StyledElement
 * Visual
 * Layoutable
 * Interactive
 * InputElement +
 * Control +
 * TemplatedControl
 * ContentControl
 */

class UxButton extends ButtonTemplate {
    use UxInputElementTemplate;
    use UxControlTemplate;
    use UxTemplatedControlEventsTemplate;
    use UxButtonEventsTemplate;
}