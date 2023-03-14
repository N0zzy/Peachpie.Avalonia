using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

public class UxRelativePanel<T> : UxPanel<T> where T : RelativePanel, new()
{
    
}

public class UxRelativePanel : UxRelativePanel<RelativePanel>
{
    
}