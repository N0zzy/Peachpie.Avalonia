using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// The UxMaskedTextBox control is an editable text field where a user can input text.
/// </summary>
public class UxMaskedTextBox<T> : UxTextBox<T> where T : MaskedTextBox
{
    
}

/// <summary>
/// The UxMaskedTextBox control is an editable text field where a user can input text.
/// </summary>
public class UxMaskedTextBox : UxTextBox<MaskedTextBox>
{
    
}