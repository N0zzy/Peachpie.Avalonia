<?php

namespace SharPie\Controls;

use Peachpie\Avalonia\ControlsTemplates\ButtonTemplate;

use SharPie\Templates\EventsTemplates\UxButtonEventsTemplate;
use SharPie\Templates\UxAvaloniaObjectTemplate;
use SharPie\Templates\UxControlTemplate;
use SharPie\Templates\UxInputElementTemplate;
use SharPie\Templates\UxTemplatedControlTemplate;

/**
 * AvaloniaObject +
 * Animatable
 * StyledElement
 * Visual
 * Layoutable
 * Interactive
 * InputElement +
 * Control +
 * TemplatedControl +
 * ContentControl
 */

class UxButton extends ButtonTemplate {
    use UxAvaloniaObjectTemplate;
    use UxInputElementTemplate;
    use UxControlTemplate;
    use UxTemplatedControlTemplate;
    use UxButtonEventsTemplate;
}