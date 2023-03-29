<?php

namespace Application\Forms;

use Peachpie\Avalonia\Controls\UxButton;
use Peachpie\Avalonia\Controls\UxStackPanel;
use Peachpie\Avalonia\Controls\UxWindow;

class NewWindow extends UxWindow
{
    public function __construct()
    {
        $this->Title = "newWindow";
        $this->Name = "NewWindow";
        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel = new UxStackPanel();

        $button = new UxButton();
        $button->Content = "Скрыть MainWindow";

        $thisForm = $this;
        $button->on('Click', function (UxButton $button, $args) use ($thisForm) {
            $MainWindow = $thisForm->form('MainWindow');

            if($MainWindow->IsVisible) {
                $button->Content = "Показать MainWindow";
                $MainWindow->Hide();
            } else {
                $button->Content = "Скрыть MainWindow";
                $MainWindow->Show();
            }

        });



        $UxStackPanel->Children->Add($button->WrappedObject);

        $this->Content = $UxStackPanel;
    }
}