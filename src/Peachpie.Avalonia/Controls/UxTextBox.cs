using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Represents a control that can be used to display or edit unformatted text.
/// </summary>
public class UxTextBox<T> : UxTemplatedControl<T> where T : TextBox
{
    
}

/// <summary>
/// Represents a control that can be used to display or edit unformatted text.
/// </summary>
public class UxTextBox : UxTextBox<TextBox>
{
    
}