using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

public class UxContentControl<T> : UxTemplatedControl<T> where T: ContentControl
{
    
}

public class UxContentControl : UxContentControl<ContentControl>
{
    
}