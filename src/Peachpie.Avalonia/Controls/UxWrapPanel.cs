using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

public class UxWrapPanel<T> : UxPanel<T> where T : WrapPanel, new()
{
    
}

public class UxWrapPanel : UxWrapPanel<WrapPanel>
{
    
}