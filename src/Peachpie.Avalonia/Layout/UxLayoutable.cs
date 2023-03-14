using Avalonia.Layout;

namespace Peachpie.Avalonia.Layout;

public class UxLayoutable<T> : UxVisual<T> where T: Layoutable, new()
{
    /// <summary>
    /// Gets or sets the element's preferred horizontal alignment in its parent.
    /// </summary>
    public HorizontalAlignment HorizontalAlignment
    {
        get => (HorizontalAlignment) GetWrappedObject().HorizontalAlignment;
        set => GetWrappedObject().HorizontalAlignment = (global::Avalonia.Layout.HorizontalAlignment) value;
    }

    /// <summary>
    /// Gets or sets the element's preferred vertical alignment in its parent.
    /// </summary>
    public VerticalAlignment VerticalAlignment
    {
        get => (VerticalAlignment) GetWrappedObject().HorizontalAlignment;
        set => GetWrappedObject().VerticalAlignment = (global::Avalonia.Layout.VerticalAlignment) value;
    }
}


public class UxLayoutable : UxLayoutable<Layoutable>
{
    
}