using System;
using Avalonia.Media.Imaging;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class CroppedBitmapEventsTemplates
{
    public static PhpValue OnInvalidated(CroppedBitmap control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.Invalidated += h));
}