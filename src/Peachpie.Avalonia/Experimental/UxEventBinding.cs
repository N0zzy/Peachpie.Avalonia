using System;
using System.Collections.Generic;
using System.Reflection;
using Pchp.Core;
using Peachpie.Avalonia.ControlsTemplates;
using Peachpie.Avalonia.ControlsTemplates.EventsTemplates;

namespace Peachpie.Avalonia.Experimental;

public class UxEventBinding
{
    public UxEventBinding()
    {
        foreach (var eventMethod in typeof(InputElementEventsTemplate).GetMethods())
        {
            _eventMethodsDictionary.Add(eventMethod.Name, eventMethod);
        }
    }

    public void On(ButtonTemplate button, PhpValue eventName, Closure callback)
    {
        _eventMethodsDictionary[eventName.String].Invoke(null, new object[]
        { 
            button,
            (EventArgs a) =>
            {
                callback.call(this, PhpValue.FromClass(button), PhpValue.FromClass(a));
            }
        });
    }

    private Dictionary<string, MethodInfo> _eventMethodsDictionary = new();
    
}