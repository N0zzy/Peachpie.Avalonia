<?php

namespace SharPie\Templates;

use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\ButtonEventsTemplates;
use SharPie\Controls\UxButton;
use Closure;


trait UxButtonTemplate
{
    use UxAvaloniaObjectTemplate;
    use UxAnimatableTemplate;
    use UxStyledElementTemplate;
    use UxVisualTemplate;
    use UxLayoutableTemplate;
    use UxInteractiveTemplate;
    use UxInputElementTemplate;
    use UxControlTemplate;
    use UxTemplatedControlTemplate;
    use UxContentControlTemplate;


    #Events
    /**
     * @param Closure $callback
     * @return UxButton
     */
    public function on_Click($callback) : UxButton
    {
        return ButtonEventsTemplates::OnClick($this, $callback);
    }

    #Fields


}