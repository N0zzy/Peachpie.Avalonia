using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Represents a control that provides a text box for user input and a
/// drop-down that contains possible matches based on the input in the text
/// box.
/// </summary>
public class UxAutoCompleteBox<T> : UxTemplatedControl<T> where T : AutoCompleteBox
{
    
}

/// <summary>
/// Represents a control that provides a text box for user input and a
/// drop-down that contains possible matches based on the input in the text
/// box.
/// </summary>
public class UxAutoCompleteBox : UxAutoCompleteBox<AutoCompleteBox>
{
    
}