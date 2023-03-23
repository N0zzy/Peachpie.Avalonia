using Avalonia.Animation;

namespace Peachpie.Avalonia.Animation;

/// <summary>
/// Base class for all animatable objects.
/// </summary>
public class UxAnimatable<T> : UxAvaloniaObject<T> where T : Animatable
{
    
}

/// <summary>
/// Base class for all animatable objects.
/// </summary>
public class UxAnimatable : UxAvaloniaObject<Animatable>
{
 
}
