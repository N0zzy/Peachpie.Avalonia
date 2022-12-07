using System;
using Avalonia;

namespace Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

public static class SetEventToControl
{
    public static TControl _setEvent<TControl, THandler>(this TControl control, THandler handler, Action<THandler> subscribe)
        where TControl : AvaloniaObject
    {
        subscribe?.Invoke(handler);
        return control;
    }
}