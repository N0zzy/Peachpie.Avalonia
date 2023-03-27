using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// A control to allow the user to select a time.
/// </summary>
public class UxTimePicker<T> : UxTemplatedControl<T> where T : TimePicker
{
    
}

/// <summary>
/// A control to allow the user to select a time.
/// </summary>
public class UxTimePicker : UxTimePicker<TimePicker>
{
    
}