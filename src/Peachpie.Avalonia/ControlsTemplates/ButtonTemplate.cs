using System;
using System.Runtime.CompilerServices;

using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Avalonia.Styling;
using Pchp.Core;
using Peachpie.Avalonia.ControlsTemplates.PropertyTemplates;

namespace Peachpie.Avalonia.ControlsTemplates;



/// <summary>
/// A standard button control.
/// </summary>
public class ButtonTemplate : Button , IStyleable
{
    [PhpHidden] public Type StyleKey => typeof(Button);
    
    public new ButtonTemplate Content(object value = default, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null, [CallerArgumentExpression("value")] string ps = null)
        => this._setEx(ContentProperty, ps, () => base.Content = value, bindingMode, converter,
            bindingSource);

    #region Property
    
    /// <summary>
    /// Sets a value indicating how the Button should react to clicks.
    /// </summary>
    public new ButtonTemplate ClickMode(ClickMode value = default, BindingMode? bindingMode = null,
        IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null) => this._setEx(ClickModeProperty, ps,
        () => base.ClickMode = value, bindingMode, converter, bindingSource);
    
    /// <summary>
    /// Sets an ICommand to be invoked when the button is clicked.
    /// </summary>
    public new ButtonTemplate Command(ICommand value = default, BindingMode? bindingMode = null,
        IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null) => this._setEx(CommandProperty, ps,
        () => base.Command = value, bindingMode, converter, bindingSource);
    
    /// <summary>
    /// Sets an KeyGesture associated with this control
    /// </summary>
    public new ButtonTemplate HotKey(KeyGesture value = default, BindingMode? bindingMode = null,
        IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null) => this._setEx(HotKeyProperty, ps,
        () => base.HotKey = value, bindingMode, converter, bindingSource);
    
    /// <summary>
    /// Sets a parameter to be passed to the Command.
    /// </summary>
    public new ButtonTemplate CommandParameter(Object value = default, BindingMode? bindingMode = null,
        IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null) => this._setEx(CommandParameterProperty, ps,
        () => base.CommandParameter = value, bindingMode, converter, bindingSource);
    
    /// <summary>
    /// Sets a value indicating whether the button is the default button for the window.
    /// </summary>
    public new ButtonTemplate IsDefault(Boolean value = default, BindingMode? bindingMode = null,
        IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null) => this._setEx(IsDefaultProperty, ps,
        () => base.IsDefault = value, bindingMode, converter, bindingSource);

    /// <summary>
    /// Sets a value indicating whether the button is the Cancel button for the window.
    /// </summary>
    public new ButtonTemplate IsCancel(Boolean value = default, BindingMode? bindingMode = null,
        IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null) => this._setEx(IsCancelProperty, ps,
        () => base.IsCancel = value, bindingMode, converter, bindingSource);
    
    /// <summary>
    /// Sets the Flyout that should be shown with this button.
    /// </summary>
    public new ButtonTemplate Flyout(FlyoutBase value = default, BindingMode? bindingMode = null,
        IValueConverter converter = null, object bindingSource = null,
        [CallerArgumentExpression("value")] string ps = null) => this._setEx(FlyoutProperty, ps,
        () => base.Flyout = value, bindingMode, converter, bindingSource);
    
    #endregion
}