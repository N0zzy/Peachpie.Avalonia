<?php

namespace Peachpie\Avalonia\Controls;

abstract class UxWindow
{

    /**
     * 
     * @param string $form
     * @return UxWindow
     */
    public function form(string $form)
    {
    }

    /**
     * Shows the window.
     *
     * @return void
     */
    public function Show(): void
    {
    }

    /**
     * Hides the window but does not close it.
     *
     * @return void
     */
    public function Hide(): void
    {
    }

    /**
     * Closes the window.
     *
     * @return void
     */
    public function Close(): void
    {
    }

    /**
     * @return string
     */
    public function __toString()
    {
    }
}