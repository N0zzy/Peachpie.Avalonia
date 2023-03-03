<?php

namespace Application\Forms;

use SharPie\Controls\{ UxWindow,UxButton, UxStackPanel, UxOpenFileDialog, UxListBox };
use Pchp\Core\PhpValue;
use Peachpie\Avalonia\ControlsTemplates\EventAttribute;
use Avalonia\Controls\SelectionChangedEventArgs;

class MainWindow extends UxWindow {

    public UxOpenFileDialog $UxOpenFileDialog;

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


    public function __construct() {
       
        $this->Title = "ApplicationDesktop";


        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();
        $this->Content = $UxStackPanel;

        $OpenToDoListForm = new UxButton();
        $OpenToDoListForm->Name = "button1"; //Уникальный едентификатор кнопки
        $OpenToDoListForm->Content = "OpenFileDialog";
        $OpenToDoListForm->Width = 150;

        $items = [
            "Item 1",
            "Item 2",
            "Item 3",
        ];

        $ListBox = new UxListBox();
        $ListBox->Items = $items;
        $ListBox->on('SelectionChanged', function( $sender, $e){
            echo $e;
        });

        $UxStackPanel->Children->Add($OpenToDoListForm);
        $UxStackPanel->Children->Add($ListBox->Control);

        $array = array();
        $this->UxOpenFileDialog = new UxOpenFileDialog($array);

        $this->UxOpenFileDialog->OnFileSelected(function($OpenFileDialogEventArgs){
                $this->Title =  $OpenFileDialogEventArgs->SelectedFiles[0];
        });


        //Экспирементальное навешевание трегеров на контроллы
        $this->setEventsAttribute($UxStackPanel);


     }
     //Некоторые свойства вызывают ошибку типов, данный метод позволяет её обойти
     private function getContent($value) {
         return PhpValue::FromClass($value);
     }


     

}