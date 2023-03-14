<?php

namespace Peachpie\Avalonia\Layout;

/**
 * Defines how a control aligns itself vertically in its parent control.
 *
 */
enum VerticalAlignment: int
{
    // The control stretches to fill the height of the parent control.
    case Stretch = 0;
    // The control aligns itself to the top of the parent control.
    case Top = 1;
    //The control centers itself within the parent control.
    case Center = 2;
    // The control aligns itself to the bottom of the parent control.
    case Bottom = 3;
}