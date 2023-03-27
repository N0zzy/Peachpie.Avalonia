using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Base class for controls which decorate a single child control.
/// </summary>
public class UxDecorator<T> : UxControl<T> where T : Decorator
{
   
}

/// <summary>
/// Base class for controls which decorate a single child control.
/// </summary>
public class UxDecorator : UxDecorator<Decorator>
{
    
}