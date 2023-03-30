using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Interfaces;
using Peachpie.Avalonia.Input;

namespace Peachpie.Avalonia.Controls;

public class UxControl<T> : UxInputElement<T> , IUxControl where T : Control
{ 
    public object WrappedControl => WrappedObject;
}




public class UxControl : UxControl<Control>
{
    
}