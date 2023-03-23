using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

public class UxDockPanel<T> : UxPanel<T> where T : DockPanel
{
    
}

public class UxDockPanel : UxDockPanel<DockPanel>
{
    
}