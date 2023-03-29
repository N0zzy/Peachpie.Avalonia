using System.Collections.Generic;
using Avalonia.Collections;
using Avalonia.Controls;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia.Controls;

public class UxControls: AvaloniaList<object>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Avalonia.Controls.Controls"/> class.
    /// </summary>
    public UxControls()
    {
        ResetBehavior = ResetBehavior.Remove;
    }

    /// <summary>
    /// Adds an item to the collection.
    /// </summary>
    /// <param name="item">The item.</param>
    public virtual void Add(IBaseWrapper item)
    {
        base.Add(item.GetWrappedObject());
    }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Controls"/> class.
    /// </summary>
    /// <param name="items">The initial items in the collection.</param>
    public UxControls(IEnumerable<UxControl> items)
        : base(items)
    {
        ResetBehavior = ResetBehavior.Remove;
    }
}