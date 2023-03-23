using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// A check box control.
/// </summary>
public class UxCheckBox<T> : UxToggleButton<T> where T : CheckBox
{

}

/// <summary>
/// A check box control.
/// </summary>
public class UxCheckBox : UxCheckBox<CheckBox>
{
    
}