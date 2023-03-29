<?php

namespace Application\Forms;

use Peachpie\Avalonia\Controls\{UxWindow, UxStackPanel, UxListBox, UxButton, UxCheckBox};
use Peachpie\Avalonia\Layout\HorizontalAlignment;

class MainWindow extends UxWindow
{

    public function __construct()
    {
        $this->Title = "ApplicationDesktop";
        $this->Name = "MainWindow";
        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel = new UxStackPanel();


        $ListBox = new UxListBox();
        $ListBox->Items->add('Hello World');
        $UxButton = new UxButton();
        $UxButton->Name = "button1";
        $UxButton->Content = "Open NewWindow";


        $UxButton->Width = $this->Width / 2;
        $UxButton->HorizontalAlignment = HorizontalAlignment::Left;


        $UxCheckBox = new UxCheckBox();

        $data = $this;
        $newWindow = new NewWindow();
        $UxButton->on('Click', function (UxButton $sender, $e) use ($newWindow, $UxCheckBox, $ListBox) {

            $IsChecked = $UxCheckBox->IsChecked ? 'AddToList - true' : 'AddToList - false';
            $ListBox->Items->Add($IsChecked);

            $newWindow->Show();
        });

        $UxStackPanel->Children->Add($ListBox->WrappedObject);
        $UxStackPanel->Children->Add($UxButton->WrappedObject);
        $UxStackPanel->Children->Add($UxCheckBox->WrappedObject);
        

        $this->Content = $UxStackPanel;
    }

}