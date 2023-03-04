<?php

namespace Application\Forms;

use Pchp\Core\PhpValue;

use Peachpie\Avalonia\ControlsTemplates\EventAttribute;

use Peachpie\Avalonia\Controls\ {UxWindow, UxStackPanel, UxListBox , UxButton};

class MainWindow extends UxWindow {


    /* Устаревшее
    #[EventAttribute("button1", "on_Click")]
    public function Clicked(UxButton $button, $args) {
        $button->Content = "Opened";
        $this->UxOpenFileDialog->Open($this);
    }

    #[EventAttribute("button1", "on_PointerEntered")]
    public function Entered(UxButton $button, $args) {
        $button->Content = "The cursor on the button";
    }

    #[EventAttribute("button1", "on_PointerExited")]
    public function Exited(UxButton $button, $args) {
        $button->Content = "OpenFileDialog";
    }

    //Экспирементальное навешевание трегеров на контроллы
    //$this->setEventsAttribute($UxStackPanel);

    */

    //Доступ к свойствам компонента через $compoent->Control, либо через SetProperty и GetProperty

    public function __construct() {

        $this->SetProperty("Title","ApplicationDesktop");
        $this->SetProperty("Width", 400);
        $this->SetProperty("Height",400);

        $UxStackPanel =  new UxStackPanel();

        $this->Control->Content = $UxStackPanel->Control;

        $ListBox = new UxListBox();

        $ListBox->Items = [
             "Item 1",
             "Item 2",
             "Item 3",
        ];

        $UxStackPanel->Control->Children->Add($ListBox->Control);

        $UxButton = new UxButton();
        $UxButton->SetProperty("Content","Button1") ;
        $UxButton->on('Click', function( $sender, $e) {
            $sender->Content = "Tapped";
        });

        $UxStackPanel->GetProperty("Children")->Add($UxButton->Control);
     }
     //Некоторые свойства вызывают ошибку типов, данный метод позволяет её обойти
     private function getContent($value) {
         return PhpValue::FromClass($value);
     }


     

}