<?php

namespace SharPie\Controls;

use Peachpie\Avalonia\ControlsTemplates\WindowTemplate;
use SharPie\Templates\UxControlTemplate;
use SharPie\Templates\UxInputElementTemplate;


class UxWindow extends WindowTemplate {
    use UxInputElementTemplate;
    use UxControlTemplate;
}