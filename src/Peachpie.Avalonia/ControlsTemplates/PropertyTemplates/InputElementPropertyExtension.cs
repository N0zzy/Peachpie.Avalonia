using System.Runtime.CompilerServices;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Pchp.Core;

namespace Peachpie.Avalonia.ControlsTemplates.PropertyTemplates;

public static class InputElementPropertyTemplate
{
   
   public static PhpValue Focusable(InputElement control, bool value = default, BindingMode? bindingMode = null,
      IValueConverter converter = null, object bindingSource = null,
      [CallerArgumentExpression("value")] string ps = null)
   {
      return PhpValue.FromClass(control._setEx(InputElement.FocusableProperty, ps, () => control.Focusable = value, bindingMode,
         converter, bindingSource));
   }
   

   public static PhpValue IsEnabled(InputElement control, bool value = default, BindingMode? bindingMode = null,
      IValueConverter converter = null, object bindingSource = null,
      [CallerArgumentExpression("value")] string ps = null)
   {
      return PhpValue.FromClass(control._setEx(InputElement.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter,
         bindingSource));
   }
   
   
   public static PhpValue Cursor(InputElement control, Cursor value = default, BindingMode? bindingMode = null,
      IValueConverter converter = null, object bindingSource = null,
      [CallerArgumentExpression("value")] string ps = null)
   {
      return PhpValue.FromClass(control._setEx(InputElement.CursorProperty, ps, () => control.Cursor = value, bindingMode, converter,
         bindingSource));
   }
   
   public static PhpValue IsHitTestVisible(InputElement control, bool value = default, BindingMode? bindingMode = null,
      IValueConverter converter = null, object bindingSource = null,
      [CallerArgumentExpression("value")] string ps = null)
   {
      return PhpValue.FromClass(control._setEx(InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = value,
         bindingMode,
         converter, bindingSource));
   }
   
   public static PhpValue IsTabStop(InputElement  control, bool value = default, BindingMode? bindingMode = null,
      IValueConverter converter = null, object bindingSource = null,
      [CallerArgumentExpression("value")] string ps = null)
   {
      return PhpValue.FromClass(control._setEx(InputElement.IsTabStopProperty, ps, () => control.IsTabStop = value, bindingMode, converter,
         bindingSource));
   }
   
   public static PhpValue TabIndex(InputElement control, int value = default, BindingMode? bindingMode = null,
      IValueConverter converter = null, object bindingSource = null,
      [CallerArgumentExpression("value")] string ps = null)
   {
      return PhpValue.FromClass(control._setEx(InputElement.TabIndexProperty, ps, () => control.TabIndex = value, bindingMode, converter,
         bindingSource));
   }

}