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
        $OpenToDoListForm->Content = "ToDoListForm";

        $data = "100.1";
        $OpenToDoListForm->on_Click(function($RoutedEventArgs) use ($OpenToDoListForm, $data){
            var_dump($data);
            var_dump("#########################################");
            $OpenToDoListForm->Content($data);
            var_dump($OpenToDoListForm->Content);
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

     private function asObject($value): object {
         return PhpValue::FromClass($value);
     }

}