using System;
using Avalonia;
using Avalonia.Data;
using Pchp.Core;

namespace Peachpie.Avalonia.Experimental.classes;

public class UxAvaloniaObject<T> : BaseWrapper<T> where T : AvaloniaObject, new()
{
  
    /// <summary>
    /// Checks that the current thread is the UI thread.
    /// </summary>
    public bool CheckAccess()
    {
        return GetWrappedObject().CheckAccess();
    }

    /// <summary>
    /// Checks that the current thread is the UI thread and throws if not.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The current thread is not the UI thread.
    /// </exception>
    public void VerifyAccess()
    {
        GetWrappedObject().VerifyAccess();
    }

    /// <summary>
    /// Clears a <see cref="AvaloniaProperty"/>'s local value.
    /// </summary>
    /// <param name="property">The property.</param>
    public void ClearValue(AvaloniaProperty property)
    {
        GetWrappedObject().ClearValue(property);
    }

    /// <summary>
    /// Coerces the specified <see cref="AvaloniaProperty"/>.
    /// </summary>
    /// <param name="property">The property.</param>
    public void CoerceValue(AvaloniaProperty property)
    {
        GetWrappedObject().CoerceValue(property);
    }

    /// <summary>
    /// Gets a <see cref="AvaloniaProperty"/> value.
    /// </summary>
    /// <param name="property">The property.</param>
    /// <returns>The value.</returns>
    public PhpValue GetValue(AvaloniaProperty property)
    {
        return PhpValue.FromClass(GetWrappedObject().GetValue(property));
    }

    /// <summary>
    /// Sets a <see cref="AvaloniaProperty"/> value.
    /// </summary>
    /// <param name="property">The property.</param>
    /// <param name="value">The value.</param>
    /// <param name="priority">The priority of the value.</param>
    public IDisposable SetValue(AvaloniaProperty property, PhpValue value,
        BindingPriority priority = BindingPriority.LocalValue)
    {
        return GetWrappedObject().SetValue(property, value, priority);
    }

    /// <summary>
    /// Checks whether a <see cref="AvaloniaProperty"/> is animating.
    /// </summary>
    /// <param name="property">The property.</param>
    /// <returns>True if the property is animating, otherwise false.</returns>
    public bool IsAnimating(AvaloniaProperty property)
    {
        return GetWrappedObject().IsAnimating(property);
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
        return GetWrappedObject().IsSet(property);
    }

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
        return GetWrappedObject().GetHashCode();
    }

    public void BeginBatchUpdate()
    {
        GetWrappedObject().BeginBatchUpdate();
    }

    public void EndBatchUpdate()
    {
        GetWrappedObject().EndBatchUpdate();
    }

    // public void GetBaseValue()
    // {
    //     GetWrappedObject().GetBaseValue();
    // }

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
        return GetWrappedObject().Equals(obj);
    }

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
}
