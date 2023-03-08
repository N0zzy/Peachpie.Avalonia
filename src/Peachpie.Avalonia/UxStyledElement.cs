using Avalonia;
using Peachpie.Avalonia.Controls.Animation;

namespace Peachpie.Avalonia;

public class UxStyledElement<T> : UxAnimatable<T> where T : StyledElement, new()
{
    
}

public class UxStyledElement : UxStyledElement<StyledElement>
{
    
}