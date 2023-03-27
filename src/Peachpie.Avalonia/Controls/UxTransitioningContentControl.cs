using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// The UxTransitioningContentControl is a UxContentControl which can render PageTransitions when the Content changes.
/// </summary>
public class UxTransitioningContentControl<T> : UxContentControl<T> where T : TransitioningContentControl
{
    
}

/// <summary>
/// The UxTransitioningContentControl is a UxContentControl which can render PageTransitions when the Content changes.
/// </summary>
public class UxTransitioningContentControl : UxTransitioningContentControl<TransitioningContentControl>
{
    
}