using System;
using Avalonia.Controls.Presenters;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class TextPresenterEventsExtension
{
    public static TextPresenter OnCaretBoundsChanged(TextPresenter control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.CaretBoundsChanged += h);
}