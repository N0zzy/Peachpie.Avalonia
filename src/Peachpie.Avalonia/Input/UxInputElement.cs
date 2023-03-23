using Avalonia.Input;
using Peachpie.Avalonia.Interactivity;

namespace Peachpie.Avalonia.Input;

public class UxInputElement<T> : UxInteractive<T> where T : InputElement
{
    
}

public class UxInputElement : UxInputElement<InputElement>
{
    
}

