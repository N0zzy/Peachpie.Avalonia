<?php

namespace Peachpie\Avalonia\Controls;

/**
 * Defines how a UxButton reacts to clicks.
 *
 */
enum ClickMode: int
{
    case Release = 0;
    case Press = 1;
}

/**
 * A standard button control.
 *
 */
class UxButton extends UxContentControl
{

    /**
     * @var ClickMode Defines how a UxButton reacts to clicks.
     */
    public ClickMode $ClickMode;
}