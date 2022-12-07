using System;
using System.Collections.Specialized;
using Avalonia.Styling;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class StylesEventsTemplates
{
    public static PhpValue OnCollectionChanged(Styles control, Action action) =>
        PhpValue.FromClass(control._setEvent((NotifyCollectionChangedEventHandler)((_, args) => action()),
            h => control.CollectionChanged += h));

    public static PhpValue OnOwnerChanged(Styles control, Action action) =>
        PhpValue.FromClass(control._setEvent((EventHandler)((_, args) => action()), h => control.OwnerChanged += h));
}