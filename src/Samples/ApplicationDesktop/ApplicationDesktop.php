﻿<?php

namespace Application\Desktop;

use Peachpie\Avalonia\Platform\UxApplication;
use Application\Forms\MainWindow;

$UxApplication = new UxApplication(callback: function () {
    return new MainWindow();
});