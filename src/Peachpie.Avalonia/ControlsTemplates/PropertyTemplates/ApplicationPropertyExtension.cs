using System;
using System.Runtime.CompilerServices;
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;

namespace Peachpie.Avalonia.ControlsTemplates.PropertyTemplates;

public class ApplicationPropertyExtension
{
    
    public Application DataContext(Application control, Object value = default,
        BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null)
    {
        return control._setEx(Application.DataContextProperty, ps, () => control.DataContext = value, bindingMode,
            converter, bindingSource);
    }
    
    public Application Name(Application control, String value = default, BindingMode? bindingMode = null,
        IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null)
    {
        return control._setEx(Application.NameProperty, ps, () => control.Name = value, bindingMode, converter,
            bindingSource);
    }
    
}

