<?php

namespace Application\Forms;

use Peachpie\Avalonia\Controls\ {
    UxWindow,
    UxStackPanel,
    UxListBox,
    UxButton,
    UxCheckBox,
    UxCanvas
};
use Peachpie\Avalonia\Experimental\X;
############Классы заглушки#########
class StackPanel extends UxStackPanel {

}

class ListBox extends UxListBox {

}

class Button extends UxButton {

}

class CheckBox extends UxCheckBox {

}
#####################################

class MainWindow extends UxWindow {


    public function __construct()
    {
        $this->Title = "ApplicationDesktop";
        $this->Width = 400;
        $this->Height = 400;

        $UxStackPanel = new StackPanel();


        $ListBox = new ListBox();
        $ListBox->Items->Add('Hello World');


        $UxButton = new Button();
        $UxButton->Name = "button1";
        $UxButton->Content = "Button1";
        $UxButton->Width = $this->Width/2;

        $UxCheckBox = new CheckBox();

        $str = 100000;

        $UxButton->on('Click', function($sender, $e) use ($UxCheckBox, $ListBox, $str ) {
            $IsChecked = $UxCheckBox->IsChecked ? 'AddToList - true' : 'AddToList - false';
            $ListBox->Items->Add($IsChecked);
            $sender->Content = $IsChecked;
        });

        $UxStackPanel->Children->Add($ListBox->GetWrappedObject());
        $UxStackPanel->Children->Add($UxButton->GetWrappedObject());
        $UxStackPanel->Children->Add($UxCheckBox->GetWrappedObject());


        $this->Content = $UxStackPanel->GetWrappedObject();
    }
}