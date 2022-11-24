using System;
using System.Collections.Specialized;
using Avalonia.Styling;

namespace Peachpie.Avalonia.ControlsTemplates.EventExtensions;

public class StylesEventsExtension
{
    public static Styles OnCollectionChanged(Styles control, Action action) =>
        control._setEvent((NotifyCollectionChangedEventHandler)((_, args) => action()),
            h => control.CollectionChanged += h);

    public static Styles OnOwnerChanged(Styles control, Action action) =>
        control._setEvent((EventHandler)((_, args) => action()), h => control.OwnerChanged += h);
}