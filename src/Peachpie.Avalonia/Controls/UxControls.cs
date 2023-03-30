using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Collections;
using Pchp.Core;

namespace Peachpie.Avalonia.Controls;

public class UxControls: AvaloniaList<PhpValue>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UxControls"/> class.
    /// </summary>
    public UxControls()
    {
        ResetBehavior = ResetBehavior.Remove;
       
    }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="UxControls"/> class.
    /// </summary>
    /// <param name="items">The initial items in the collection.</param>
    public UxControls(IEnumerable<PhpValue> items)
        : base(items)
    {
        ResetBehavior = ResetBehavior.Remove;
    }
    
}