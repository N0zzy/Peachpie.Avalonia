using Peachpie.Avalonia.Controls;

namespace Peachpie.Avalonia.Experimental;


/// <summary>
/// Base view class used like UxUserControl in XAML
/// </summary>
public abstract class UxViewBase<T> : UxDecorator<T> where T : ViewBase
{
    public UxViewBase()
    {
        
    }
}