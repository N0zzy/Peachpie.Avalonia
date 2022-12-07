using System;
using Avalonia.Controls.Presenters;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class TextPresenterEventsTemplates
{
    public static PhpValue OnCaretBoundsChanged(TextPresenter control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()),
            h => control.CaretBoundsChanged += h));
}