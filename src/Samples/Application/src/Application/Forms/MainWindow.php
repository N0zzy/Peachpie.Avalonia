<?php

namespace Application\Forms;

use SharPie\Controls\{ UxWindow,UxButton, UxStackPanel };
use Pchp\Core\PhpValue;

class MainWindow extends UxWindow {


    public function __construct() {

        $this->Title = "ApplicationDesktop";

        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;

        $OpenToDoListForm = new UxButton();
        $OpenToDoListForm->Content("ToDoListForm")->Width = 300;

        $data = 1000.1;
        $OpenToDoListForm->on_Click( callback: function( $RoutedEventArgs) use ($OpenToDoListForm, $data){
            $OpenToDoListForm->Content($data);
        });


         $OpenToDoListForm->on_PointerEntered(callback : function (){
                $this->Title = "Показать форму ToDoListForm";
         });



         $OpenToDoListForm->On_PointerExited(callback : function (){
                $this->Title = "Панель примеров";
         });

        $UxStackPanel->Children->Add($OpenToDoListForm);
        
     }
     //Некоторые свойства вызывают ошибку типов, данный метод позволяет её обойти
     private function getContent($value) {
         return PhpValue::FromClass($value);
     }

}