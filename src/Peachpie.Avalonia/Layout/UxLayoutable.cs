using Avalonia.Layout;

namespace Peachpie.Avalonia.Layout;

public class UxLayoutable<T> : UxVisual<T> where T: Layoutable, new()
{
    public UxLayoutable()
    {
       
    }
}


public class UxLayoutable : UxLayoutable<Layoutable>
{
    
}