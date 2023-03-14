using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls.Primitives;

public class UxToggleButton<T> : UxButton<T> where T : ToggleButton, new()
{
    
}

public class UxToggleButton : UxToggleButton<ToggleButton>
{
    
}