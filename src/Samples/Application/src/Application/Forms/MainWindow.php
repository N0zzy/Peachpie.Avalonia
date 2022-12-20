<?php

namespace Application\Forms;

use SharPie\Controls\{UxOpenFileDialog, UxWindow, UxButton, UxStackPanel};
use Pchp\Core\PhpValue;
use Avalonia\Controls\TextBlock;

class MainWindow extends UxWindow {

    public function __construct() {

        $this->Title = "ApplicationDesktop";

        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel =  new UxStackPanel();

        $this->Content = $UxStackPanel;

        $OpenToDoListForm = new UxButton();
        $OpenToDoListForm->Content("OpenFileDialog");

        $Filters = [
            [
                "Name" => "Txt",
                ["Extensions" => "txt"]
            ],
            [
                "Name" => "All",
                ["Extensions" => "*"]
            ]
        ];

        $OpenFileDialog = new UxOpenFileDialog($Filters);
        $OpenFileDialog->Title = "Выбрать файл";
        $OpenFileDialog->AllowMultiple = false;


        $UxTextBlock = new TextBlock();
        $UxTextBlock->Text = "ссылка на файл";

        $OpenToDoListForm->on_Click( callback: function($RoutedEventArgs) use ($OpenFileDialog){
            $OpenFileDialog->Open($this);
        });
        $OpenFileDialog->OnFileSelected(function($OpenFileDialogEventArgs) use ($UxTextBlock){
            $UxTextBlock->Text = $OpenFileDialogEventArgs->SelectedFiles[0];
        });


        $OpenToDoListForm->on_PointerEntered(callback : function () use ($OpenToDoListForm){
            $this->Title = "Показать OpenFileDialog";
        });

        $OpenToDoListForm->On_PointerExited(callback : function () use ($OpenToDoListForm){
                $this->Title = "Панель примеров";
        });

        /*
        $OpenToDoListForm->on_PropertyChanged(callback: function ($AvaloniaPropertyChangedEventArgs){
            echo $AvaloniaPropertyChangedEventArgs->Property->Name;
        });
        */

        $UxStackPanel->Children->Add($OpenToDoListForm);
        $UxStackPanel->Children->Add($UxTextBlock);

     }
     //Некоторые свойства вызывают ошибку типов, данный метод позволяет её обойти
     private function getContent($value) {
         return PhpValue::FromClass($value);
     }

}