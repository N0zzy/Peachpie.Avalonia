using System;
using Avalonia.Media.Imaging;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class CroppedBitmapEventsExtension
{
    public static CroppedBitmap OnInvalidated(CroppedBitmap control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h);
}