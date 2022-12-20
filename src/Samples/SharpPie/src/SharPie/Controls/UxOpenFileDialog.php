<?php

namespace SharPie\Controls;

use Peachpie\Avalonia\ControlsTemplates\OpenFileDialogTemplate;
use Application\Forms\MainWindow;
use Closure;


/**
 * Represents a system dialog that allows the user to select one or more files to open.
 * @method Open(MainWindow $param) Открыть диалог выбора файлов.
 * @method OnFileSelected(Closure $param) Вызывается при выборе файлов.
 * @property string $Title Gets or sets the dialog title.
 * @property string $InitialFileName Gets or sets initial file name that is displayed when the dialog is opened.
 * @property bool $AllowMultiple Gets or sets a value indicating whether the user can select multiple files.
 * @property $Filters
 */
class UxOpenFileDialog extends OpenFileDialogTemplate
{
    public function __construct($Filters)
    {

    }
}