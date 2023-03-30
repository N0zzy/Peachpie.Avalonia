using System.Collections.Generic;
using Avalonia.Collections;
using Avalonia.Controls;
using Peachpie.Avalonia.Controls.Interfaces;

namespace Peachpie.Avalonia.Controls;

public class UxControls: AvaloniaList<IUxControl>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UxControls"/> class.
    /// </summary>
    public UxControls()
    {
        ResetBehavior = ResetBehavior.Remove;
    }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Controls"/> class.
    /// </summary>
    /// <param name="items">The initial items in the collection.</param>
    public UxControls(IEnumerable<IUxControl> items)
        : base(items)
    {
        ResetBehavior = ResetBehavior.Remove;
    }
    
}