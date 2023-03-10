using Avalonia;
using Avalonia.Controls;
using Pchp.Core;

namespace Peachpie.Avalonia.Controls;

public class UxButton<T> : UxContentControl<T> where T : Button, new()
{
    
}

public class UxButton : UxButton<Button>
{
    
}