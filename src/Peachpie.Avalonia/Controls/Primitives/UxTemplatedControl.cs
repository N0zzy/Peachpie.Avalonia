using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls.Primitives;

public class UxTemplatedControl<T> : UxControl<T> where T: TemplatedControl
{
    
}

public class UxTemplatedControl : UxTemplatedControl<TemplatedControl>
{
    
}