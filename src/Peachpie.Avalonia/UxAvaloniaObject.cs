﻿using System;
using Avalonia;
using Avalonia.Data;
using Pchp.Core;
using Peachpie.Avalonia.Experimental;

namespace Peachpie.Avalonia;

/// <summary>
/// An object with <see cref="AvaloniaProperty"/> support.
/// </summary>
/// <remarks>
/// This class is analogous to DependencyObject in WPF.
/// </remarks>
public class UxAvaloniaObject<T> : BaseWrapper<T> where T : AvaloniaObject
{
    /*
    /// <summary>
    /// Binds a <see cref="AvaloniaProperty"/> to an observable.
    /// </summary>
    /// <param name="property">The property.</param>
    /// <param name="source">The observable.</param>
    /// <param name="priority">The priority of the binding.</param>
    /// <returns>
    /// A disposable which can be used to terminate the binding.
    /// </returns>
    public IDisposable Bind(AvaloniaProperty property, IObservable<object?> source,
        BindingPriority priority = BindingPriority.LocalValue)
    {
        return GetWrappedObject().Bind(property, source, priority);
    }
    */
    
    /// <summary>
    /// Checks that the current thread is the UI thread.
    /// </summary>
    public bool CheckAccess()
    {
        return WrappedObject.CheckAccess();
    }
    
    /// <summary>
    /// Clears a <see cref="AvaloniaProperty"/>'s local value.
    /// </summary>
    /// <param name="property">The property.</param>
    public void ClearValue(AvaloniaProperty property)
    {
        WrappedObject.ClearValue(property);
    }
    
    /// <summary>
    /// Coerces the specified <see cref="AvaloniaProperty"/>.
    /// </summary>
    /// <param name="property">The property.</param>
    public void CoerceValue(AvaloniaProperty property)
    {
        WrappedObject.CoerceValue(property);
    }
    
    /// <summary>
    /// Compares two objects using reference equality.
    /// </summary>
    /// <param name="obj">The object to compare.</param>
    /// <remarks>
    /// Overriding Equals and GetHashCode on an AvaloniaObject is disallowed for two reasons:
    /// 
    /// - AvaloniaObjects are by their nature mutable
    /// - The presence of attached properties means that the semantics of equality are
    ///   difficult to define
    /// 
    /// See https://github.com/AvaloniaUI/Avalonia/pull/2747 for the discussion that prompted
    /// this.
    /// </remarks>
    public sealed override bool Equals(object? obj)
    {
        return WrappedObject.Equals(obj);
    }
    
    // public void GetBaseValue()
    // {
    //     GetWrappedObject().GetBaseValue();
    // }
    
    /// <summary>
    /// Gets the hash code for the object.
    /// </summary>
    /// <remarks>
    /// Overriding Equals and GetHashCode on an UxAvaloniaObject is disallowed for two reasons:
    /// 
    /// - UxAvaloniaObjects are by their nature mutable
    /// - The presence of attached properties means that the semantics of equality are
    ///   difficult to define
    /// 
    /// See https://github.com/AvaloniaUI/Avalonia/pull/2747 for the discussion that prompted
    /// this.
    /// </remarks>
    public sealed override int GetHashCode()
    {
        return WrappedObject.GetHashCode();
    }
    
    /// <summary>
    /// Gets a <see cref="AvaloniaProperty"/> value.
    /// </summary>
    /// <param name="property">The property.</param>
    /// <returns>The value.</returns>
    public PhpValue GetValue(AvaloniaProperty property)
    {
        return PhpValue.FromClass(WrappedObject.GetValue(property));
    }
    
    /// <summary>
    /// Checks whether a <see cref="AvaloniaProperty"/> is animating.
    /// </summary>
    /// <param name="property">The property.</param>
    /// <returns>True if the property is animating, otherwise false.</returns>
    public bool IsAnimating(AvaloniaProperty property)
    {
        return WrappedObject.IsAnimating(property);
    }
    
    /// <summary>
    /// Checks whether a <see cref="AvaloniaProperty"/> is set on this object.
    /// </summary>
    /// <param name="property">The property.</param>
    /// <returns>True if the property is set, otherwise false.</returns>
    /// <remarks>
    /// Checks whether a value is assigned to the property, or that there is a binding to the
    /// property that is producing a value other than <see cref="AvaloniaProperty.UnsetValue"/>.
    /// </remarks>
    public bool IsSet(AvaloniaProperty property)
    {
        return WrappedObject.IsSet(property);
    }
    
    /// <summary>
    /// Sets a <see cref="AvaloniaProperty"/> value.
    /// </summary>
    /// <param name="property">The property.</param>
    /// <param name="value">The value.</param>
    /// <param name="priority">The priority of the value.</param>
    public IDisposable SetValue(AvaloniaProperty property, object value,
        BindingPriority priority = BindingPriority.LocalValue)
    {
        return WrappedObject.SetValue(property, value, priority);
    }
    
    /// <summary>
    /// Checks that the current thread is the UI thread and throws if not.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The current thread is not the UI thread.
    /// </exception>
    public void VerifyAccess()
    {
        WrappedObject.VerifyAccess();
    }
    
}

/// <summary>
/// An object with <see cref="AvaloniaProperty"/> support.
/// </summary>
/// <remarks>
/// This class is analogous to DependencyObject in WPF.
/// </remarks>
public class UxAvaloniaObject : UxAvaloniaObject<AvaloniaObject>
{
    
}
