<?php

namespace Application\Forms;

use SharPie\Controls\{ UxWindow,UxButton, UxStackPanel };
use Pchp\Core\PhpValue;

use Peachpie\Avalonia\ControlsTemplates\EventAttribute;


class MainWindow extends UxWindow {

    #[EventAttribute("button1", "on_Click")]
    public function Clicked(UxButton $button, $args) {
        $button->Content = "Кнопка нажата";
    }

    #[EventAttribute("button1", "on_PointerEntered")]
    public function Entered(UxButton $button, $args) {
        $button->Content = "Курсор на кнопке";
    }

    #[EventAttribute("button1", "on_PointerExited")]
    public function Exited(UxButton $button, $args) {
        $button->Content = "Курсор вне кнопки";
    }


    public function __construct() {
       
        $this->Title = "ApplicationDesktop";


        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;

        $OpenToDoListForm = new UxButton();
        $OpenToDoListForm->Name = "button1"; //Уникальный едентификатор кнопки
        $OpenToDoListForm->Content = "Кнопка 1";

        $UxStackPanel->Children->Add($OpenToDoListForm);


        $this->setEventsAttribute($UxStackPanel);
     }
     //Некоторые свойства вызывают ошибку типов, данный метод позволяет её обойти
     private function getContent($value) {
         return PhpValue::FromClass($value);
     }
     
     

}