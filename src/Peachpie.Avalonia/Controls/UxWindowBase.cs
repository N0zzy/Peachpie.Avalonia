using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

public class UxWindowBase<T> : UxTopLevel<T> where T : TopLevel
{
    
}

public class UxWindowBase : UxWindowBase<TopLevel> {

}