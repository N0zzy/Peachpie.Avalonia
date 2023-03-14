using Avalonia.Collections;
using Avalonia.Controls;
using Pchp.Core;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;


public class UxCarousel<T> : UxSelectingItemsControl<T> where T : Carousel, new()
{
   
}

public class UxCarousel : UxCarousel<Carousel>
{
    
}