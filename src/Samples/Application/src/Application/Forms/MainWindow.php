<?php

namespace Application\Forms;

use Pchp\Core\PhpValue;

use Peachpie\Avalonia\ControlsTemplates\EventAttribute;

use Peachpie\Avalonia\Controls\ {UxWindow, UxStackPanel, UxListBox , UxButton, UxCheckBox};

class StackPanel extends UxStackPanel {

}

class ListBox extends UxListBox {

}

class Button extends UxButton {

}

class CheckBox extends UxCheckBox {

}

class MainWindow extends UxWindow {


    /* Устаревшее
    #[EventAttribute("button1", "on_Click")]
    public function Clicked(UxButton $button, $args) {
        $button->Content = "Opened";
        $this->UxOpenFileDialog->Open($this);
    }

    //Экспирементальное навешевание трегеров на контроллы
    //$this->setEventsAttribute($UxStackPanel);

    */

    //Доступ к свойствам компонента через $compoent->Control, либо через SetProperty и GetProperty

    public function __construct()
    {
        $this->Title = "ApplicationDesktop";
        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel = new StackPanel();

        $this->Content = $UxStackPanel->getComponent();

        $ListBox = new ListBox();
        $ListBox->Items = [
            "Item 1",
            "Item 2",
            "Item 3",
        ];

        $UxStackPanel->Children->Add($ListBox->getComponent());



        $UxButton = new Button();
        $UxButton->Content = "Button1";
        $UxButton->Width = 100;

        $UxCheckBox = new CheckBox();

        $UxButton->on('Click', function($sender, $e) use ($UxCheckBox) {

            if($UxCheckBox->IsChecked){
                echo $UxCheckBox->IsChecked;
                $sender->Content = "True";
            } else {
                echo $UxCheckBox->IsChecked;
                $sender->Content = "False";
            }
        });

        $UxStackPanel->Children->Add($UxButton->getComponent());
        $UxStackPanel->Children->Add($UxCheckBox->getComponent());

    }
}