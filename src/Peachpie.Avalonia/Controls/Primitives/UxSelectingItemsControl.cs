using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls.Primitives;

public class UxSelectingItemsControl<T> : UxItemsControl<T> where T : SelectingItemsControl
{
    
}

public class UxSelectingItemsControl : UxSelectingItemsControl<SelectingItemsControl>
{
    
}