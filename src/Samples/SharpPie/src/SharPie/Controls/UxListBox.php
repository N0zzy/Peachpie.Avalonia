<?php

namespace SharPie\Controls;
use Peachpie\Avalonia\Experimental\ListBoxWrapper;

/**
 * @property $Items
 * @property $Control
 */
class UxListBox extends ListBoxWrapper
{
    public function __get($name)
    {
        echo "Получение '$name'\n";
        return $this->GetProperty($name);
    }

    public function __set($name , $value) {
        echo "Установка '$name'\n";
        $this->SetProperty($name);
    }
}