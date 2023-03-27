using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Provides the base class for defining a new control that encapsulates related existing controls and provides its own logic.
/// </summary>
public class UxUserControl<T> : UxContentControl<T> where T : UserControl
{
    
}

/// <summary>
/// Provides the base class for defining a new control that encapsulates related existing controls and provides its own logic.
/// </summary>
public class UxUserControl : UxUserControl<UserControl>
{
    
}