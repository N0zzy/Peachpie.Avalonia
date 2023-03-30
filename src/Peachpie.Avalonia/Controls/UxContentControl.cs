using System;
using Avalonia.Controls;
using Pchp.Core;
using Peachpie.Avalonia.Controls.Interfaces;
using Peachpie.Avalonia.Controls.Primitives;

namespace Peachpie.Avalonia.Controls;

public class UxContentControl<T> : UxTemplatedControl<T> where T : ContentControl
{
    public PhpValue Content
    {
        get => PhpValue.FromClr(_content);
        set
        {
            switch (Type.GetTypeCode(value.ToClr().GetType()))
            {
                case TypeCode.Object:
                    var control = (IUxControl) value.ToClr();
                    _content = control;
                    SetValue(ContentControl.ContentProperty, control.WrappedControl);
                    break;
                default:
                    _content = value.ToClr();
                    SetValue(ContentControl.ContentProperty, _content);
                    break;
            }
        }
    }

    private object _content = new();
}

public class UxContentControl : UxContentControl<ContentControl>
{
}