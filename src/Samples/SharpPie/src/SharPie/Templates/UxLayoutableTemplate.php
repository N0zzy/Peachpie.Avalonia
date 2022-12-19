<?php

namespace SharPie\Templates;

use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\LayoutableEventsTemplates;
use Closure;

trait UxLayoutableTemplate
{
    use UxAvaloniaObjectTemplate;
    use UxAnimatableTemplate;
    use UxStyledElementTemplate;
    use UxVisualTemplate;
    #Events

    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_EffectiveViewportChanged(Closure $callback)
    {
        return LayoutableEventsTemplates::OnEffectiveViewportChanged($this, $callback);
    }

}