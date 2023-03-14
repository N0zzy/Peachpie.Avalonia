<?php

namespace Peachpie\Avalonia\Layout;

use Peachpie\Avalonia\UxVisual;

class UxLayoutable extends UxVisual
{
    /**
     * Defines how a control aligns itself horizontally in its parent control.
     *
     * @var HorizontalAlignment
     */
    public HorizontalAlignment $HorizontalAlignment;

    /**
     * Defines how a control aligns itself vertically in its parent control.
     *
     * @var VerticalAlignment
     */
    public VerticalAlignment $VerticalAlignment;
}