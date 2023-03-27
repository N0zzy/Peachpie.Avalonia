using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Control that represents a TextBox with button spinners that allow incrementing and decrementing numeric values.
/// </summary>
public class UxNumericUpDown<T> : UxTemplatedControl<T> where T : NumericUpDown
{
    
}

/// <summary>
/// Control that represents a TextBox with button spinners that allow incrementing and decrementing numeric values.
/// </summary>
public class UxNumericUpDown : UxNumericUpDown<NumericUpDown>
{
    
}