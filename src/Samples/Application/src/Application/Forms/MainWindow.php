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

        $UxButton->on('Click', function($sender, $e) use ($UxCheckBox, $ListBox ) {
            $IsChecked = $UxCheckBox->IsChecked ? 'AddToList - true' : 'AddToList - false';
            $ListBox->Items->Add(''.$IsChecked); //Вылезет Error: A scalar of type 'string' used as an object добавьте "".
            $sender->Content = $IsChecked;
        });

        $UxStackPanel->Children->Add($ListBox->GetWrappedObject());
        $UxStackPanel->Children->Add($UxButton->GetWrappedObject());
        $UxStackPanel->Children->Add($UxCheckBox->GetWrappedObject());


        $this->Content = $UxStackPanel->GetWrappedObject();
    }
}