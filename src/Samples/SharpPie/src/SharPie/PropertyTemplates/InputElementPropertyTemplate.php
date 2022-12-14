<?php

namespace SharPie\PropertyTemplates;

use Peachpie\Avalonia\ControlsTemplates\PropertyTemplates\InputElementPropertyTemplate;
use SharPie\Input\UxInputElement;

trait UxInputElementPropertyTemplate
{
    /**
     * @param bool $value
     * @return UxInputElement
     */
    public function Focusable(bool $value) : UxInputElement
    {
        return InputElementPropertyTemplate::Focusable($this, $value);
    }

    /**
     * @param bool $value
     * @return UxInputElement
     */
    public function IsEnabled(bool $value) : UxInputElement
    {
        return InputElementPropertyTemplate::IsEnabled($this, $value);
    }

    /*
    public function Cursor(Cursor $value) : Object
    {
        return InputElementPropertyTemplate::Cursor($this, $value);
    }
    */

    /**
     * @param bool $value
     * @return UxInputElement
     */
    public function IsHitTestVisible(bool $value) : UxInputElement
    {
        return InputElementPropertyTemplate::IsHitTestVisible($this, $value);
    }

    /**
     * @param bool $value
     * @return UxInputElement
     */
    public function IsTabStop(bool $value) : UxInputElement
    {
        return InputElementPropertyTemplate::IsTabStop($this, $value);
    }

    /**
     * @param int $value
     * @return UxInputElement
     */
    public function TabIndex(int $value) : UxInputElement
    {
        return InputElementPropertyTemplate::TabIndex($this, $value);
    }


}