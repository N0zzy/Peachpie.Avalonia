using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

public class UxWrapPanel<T> : UxPanel<T> where T : WrapPanel
{
    
}

public class UxWrapPanel : UxWrapPanel<WrapPanel>
{
    
}