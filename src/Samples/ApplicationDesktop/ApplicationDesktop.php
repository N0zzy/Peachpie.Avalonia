<?php

namespace Application\Desktop;

use Peachpie\Avalonia\Platform\UxApplication;
use Application\Forms\MainWindow;

abstract class MaterialThemeMode
{
    public const Light = "Light";
    public const Dark = "Dark";
    public const Inherit = "Inherit";
}

$UxApplication = new UxApplication(callback: function () {
    $MainWindow = new MainWindow();
    return $MainWindow->getComponent();
}, MaterialThemeMode : MaterialThemeMode::Light);