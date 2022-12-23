<?php

namespace Application\Forms;

use SharPie\Controls\{ UxWindow,UxButton, UxStackPanel };
use Pchp\Core\PhpValue;

use Peachpie\Avalonia\ControlsTemplates\EventAttribute;


class MainWindow extends UxWindow {

    #[Event("button1", "OnClick")]
    public function Entered($args) : void {
        $this->Title = "Hello";
    }


    public function __construct() {
       
        //  $this->Title = "ApplicationDesktop";


        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;

        $OpenToDoListForm = new UxButton();
        $OpenToDoListForm->Name = "button1";
        
        $OpenToDoListForm->Content("ToDoListForm");

        $data = 1000.1;
        
        $OpenToDoListForm->on_Click( callback: function($RoutedEventArgs) use ($OpenToDoListForm, $data){
            $OpenToDoListForm->Content($data);
        });

        $UxStackPanel->Children->Add($OpenToDoListForm);

        $this->Test();
     }
     //Некоторые свойства вызывают ошибку типов, данный метод позволяет её обойти
     private function getContent($value) {
         return PhpValue::FromClass($value);
     }
     
     

}