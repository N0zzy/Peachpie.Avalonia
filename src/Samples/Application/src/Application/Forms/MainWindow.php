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
        $OpenToDoListForm->Content("ToDoListForm");

        $data = 1000.1;
        $OpenToDoListForm->on_Click( callback: function($RoutedEventArgs) use ($OpenToDoListForm, $data){
            $OpenToDoListForm->Content($data);
        });


        $OpenToDoListForm->on_PointerEntered(callback : function () use ($OpenToDoListForm){
            $this->Title = "Показать форму ToDoListForm";
            $OpenToDoListForm->Width = 300;
        });

        $OpenToDoListForm->On_PointerExited(callback : function () use ($OpenToDoListForm){
                $this->Title = "Панель примеров";
                $OpenToDoListForm->Width = 90;
        });

        /*
        $OpenToDoListForm->on_PropertyChanged(callback: function ($AvaloniaPropertyChangedEventArgs){
            echo $AvaloniaPropertyChangedEventArgs->Property->Name;
        });
        */

        $UxStackPanel->Children->Add($OpenToDoListForm);

     }
     //Некоторые свойства вызывают ошибку типов, данный метод позволяет её обойти
     private function getContent($value) {
         return PhpValue::FromClass($value);
     }

}