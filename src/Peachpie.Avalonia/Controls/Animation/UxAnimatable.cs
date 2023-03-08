using Avalonia.Animation;
using Peachpie.Avalonia.Experimental.classes;

namespace Peachpie.Avalonia.Controls.Animation;

/// <summary>
/// Base class for all animatable objects.
/// </summary>
public class UxAnimatable<T> : UxAvaloniaObject<T> where T : Animatable, new()
{
    
}

/// <summary>
/// Base class for all animatable objects.
/// </summary>
public class UxAnimatable : UxAvaloniaObject<Animatable>
{
 
}
