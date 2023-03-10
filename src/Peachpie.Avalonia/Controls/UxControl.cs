using Avalonia.Controls;
using Peachpie.Avalonia.Input;

namespace Peachpie.Avalonia.Controls;

public class UxControl<T> : UxInputElement<T> where T : Control, new()
{
    
}

public class UxControl : UxControl<Control>
{
    
}