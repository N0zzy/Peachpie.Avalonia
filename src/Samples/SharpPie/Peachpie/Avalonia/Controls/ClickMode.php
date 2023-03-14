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