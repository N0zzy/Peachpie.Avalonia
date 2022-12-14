<?php

namespace Application\Desktop;

use Peachpie\Avalonia\Platform\UxApplication;
use Application\Forms\MainWindow;

abstract class FluentThemeMode
{
    public const Light = "Light";
    public const Dark = "Dark";
}

$UxApplication = new UxApplication(callback: function () {
    return new MainWindow();
}, FluentThemeMode : FluentThemeMode::Light);