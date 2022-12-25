<?php

namespace SharPie\Templates;


use Peachpie\Avalonia\ControlsTemplates\EventsTemplates\StyledElementEventsTemplate;
use Closure;

trait UxStyledElementTemplate
{
    use UxAvaloniaObjectTemplate;
    use UxAnimatableTemplate;

    #Events
    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_AttachedToLogicalTree($callback)
    {
        return StyledElementEventsTemplate::OnAttachedToLogicalTree($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_DetachedFromLogicalTree($callback)
    {
        return StyledElementEventsTemplate::OnDetachedFromLogicalTree($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_DataContextChanged($callback)
    {
        return StyledElementEventsTemplate::OnDataContextChanged($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_Initialized($callback)
    {
        return StyledElementEventsTemplate::OnInitialized($this, $callback);
    }

    /**
     * @param Closure $callback
     * @return $this
     */
    public function on_ResourcesChanged($callback)
    {
        return StyledElementEventsTemplate::OnResourcesChanged($this, $callback);
    }

}