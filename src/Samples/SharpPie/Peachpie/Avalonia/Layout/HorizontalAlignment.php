<?php

namespace Peachpie\Avalonia\Layout;

/**
 * Defines how a control aligns itself horizontally in its parent control.
 *
 */
enum HorizontalAlignment: int
{
    //The control stretches to fill the width of the parent control.
    case Stretch = 0;
    //The control aligns itself to the left of the parent control.
    case Left = 1;
    //The control centers itself in the parent control..
    case Center = 2;
    //The control aligns itself to the right of the parent control.
    case Right = 3;
}