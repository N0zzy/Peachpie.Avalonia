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
        
        /*
        $OpenToDoListForm->OnClick(function($RoutedEventArgs){
            $ToDoListForm = new ToDoListForm();
            $ToDoListForm->Show();
        });

         $OpenToDoListForm->OnInputPointerEntered(function (){
                $this->Title = "Показать форму ToDoListForm";
         });

         $OpenToDoListForm->OnInputPointerExited(function (){
                $this->Title = "Панель примеров";
         });

        $UxStackPanel->Children->Add($OpenToDoListForm);
        */
     }

}