using Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls.Primitives;

/// <summary>
/// Base class for controls that display a value within a range.
/// </summary>
public class UxRangeBase<T> : UxTemplatedControl<T> where T : RangeBase
{
    
}

/// <summary>
/// Base class for controls that display a value within a range.
/// </summary>
public class UxRangeBase : UxRangeBase<RangeBase>
{
    
}