using System;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.PropertyTemplates;

public class ControlPropertyTemplate
{
    public PhpValue  FocusAdorner(Control control, ITemplate<IControl> value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)
        => PhpValue.FromClass(control._setEx(Control.FocusAdornerProperty, ps, () => control.FocusAdorner = value, bindingMode, converter, bindingSource));
    
    public static PhpValue Tag(Control control, Object value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)
        => PhpValue.FromClass(control._setEx(Control.TagProperty, ps, () => control.Tag = value, bindingMode, converter, bindingSource));
    
    
}