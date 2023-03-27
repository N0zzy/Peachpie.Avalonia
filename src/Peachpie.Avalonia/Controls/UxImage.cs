using Avalonia.Controls;
using Avalonia.Media.Imaging;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Displays a <see cref="Bitmap"/> image.
/// </summary>
public class UxImage<T> : UxControl<T> where T: Image  
{
    
}

/// <summary>
/// Displays a <see cref="Bitmap"/> image.
/// </summary>
public class UxImage : UxImage<Image>
{
    
}