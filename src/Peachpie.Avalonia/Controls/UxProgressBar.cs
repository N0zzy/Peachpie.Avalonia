using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// A control used to indicate the progress of an operation.
/// </summary>
public class UxProgressBar<T> : UxRangeBase<T> where T : ProgressBar
{
    
}

/// <summary>
/// A control used to indicate the progress of an operation.
/// </summary>
public class UxProgressBar : UxProgressBar<ProgressBar>
{
    
}