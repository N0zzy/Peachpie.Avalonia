<?php

namespace Application\Forms;

use Peachpie\Avalonia\Controls\{UxCarousel, UxWindow, UxStackPanel, UxListBox, UxButton, UxCheckBox};
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
        $ListBox->Items->Add('Hello World');

        $UxButton = new UxButton();
        $UxButton->Name = "button1";
        $UxButton->Content = "Button1";
        $UxButton->Width = $this->Width / 2;
        $UxButton->HorizontalAlignment = HorizontalAlignment::Left;


        $UxCheckBox = new UxCheckBox();

        $data = $this;
        $UxButton->on('Click', function (UxButton $sender, $e) use ($UxCheckBox, $ListBox, $data) {
            $IsChecked = $UxCheckBox->IsChecked ? 'AddToList - true' : 'AddToList - false';
            $ListBox->Items->Add($IsChecked);

            $newWindow = new NewWindow();
            $newWindow->Show();
        });

        $UxStackPanel->Children->Add($ListBox->GetWrappedObject());
        $UxStackPanel->Children->Add($UxButton->GetWrappedObject());
        $UxStackPanel->Children->Add($UxCheckBox->GetWrappedObject());


        $this->Content = $UxStackPanel->GetWrappedObject();
    }

}