using Avalonia.Interactivity;
using Peachpie.Avalonia.Layout;

namespace Peachpie.Avalonia.Interactivity;

public class UxInteractive<T> : UxLayoutable<T> where T : Interactive , new()
{
    
}

public class UxInteractive : UxLayoutable<Interactive>
{
    
}