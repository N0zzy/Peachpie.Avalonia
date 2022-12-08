<?php

namespace Forms;

use Controls\{ UxWindow,UxButton, UxStackPanel };

class MainWindow extends UxWindow {
     public function __construct() {

        $this->Title = "ApplicationDesktop";

        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;

        $OpenToDoListForm = new UxButton();
        $OpenToDoListForm->Content = "ToDoListForm";
        
        $value = 100.01;
        $OpenToDoListForm->on_Click(function($RoutedEventArgs) use ($OpenToDoListForm, $value){
            //$OpenToDoListForm->Content = $value; 
            echo $value;
            echo $RoutedEventArgs->Source;
        });
      
        /*
         $OpenToDoListForm->On_PointerEntered(function (){
                $this->Title = "Показать форму ToDoListForm";
         });

         $OpenToDoListForm->On_PointerExited(function (){
                $this->Title = "Панель примеров";
         });
        */
        $UxStackPanel->Children->Add($OpenToDoListForm);
        
     }

}