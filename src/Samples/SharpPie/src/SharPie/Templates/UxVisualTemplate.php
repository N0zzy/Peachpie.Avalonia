<?php

namespace SharPie\Templates;

use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\VisualEventsTemplate;
use Closure;

trait UxVisualTemplate
{
    use UxAvaloniaObjectTemplate;
    use UxAnimatableTemplate;
    use UxStyledElementTemplate;

    #Events

    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_AttachedToVisualTree(Closure $callback)
    {
        return VisualEventsTemplate::OnAttachedToVisualTree($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_DetachedFromVisualTree(Closure $callback)
    {
        return VisualEventsTemplate::OnDetachedFromVisualTree($this, $callback);
    }

}