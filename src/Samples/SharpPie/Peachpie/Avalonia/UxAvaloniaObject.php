<?php

namespace Peachpie\Avalonia;

use Closure;

/**
 * This class is analogous to DependencyObject in WPF.
 *
 * Class UxAvaloniaObject
 * @package Peachpie\Avalonia
 *
 */
class UxAvaloniaObject
{

    /**
     * Sets an event to an object.
     *
     * @param string $eventName
     * @param Closure $closure
     * @return void
     */
    public function on(string $eventName, Closure $closure): void
    {

    }

    public function BeginBatchUpdate(): void
    {

    }

    /**
     * Checks that the current thread is the UI thread.
     * @return bool
     */
    public function CheckAccess()
    {

    }

    /**
     * Clears a AvaloniaProperty's local value.
     *
     * @param AvaloniaProperty $property
     * @return void
     */
    public function ClearValue(AvaloniaProperty $property): void
    {

    }

    /**
     * Coerces the specified AvaloniaProperty.
     *
     * @param AvaloniaProperty $property
     * @return void
     */
    public function CoerceValue(AvaloniaProperty $property): void
    {

    }

    public function EndBatchUpdate(): void
    {

    }

    /**
     * Compares two objects using reference equality.
     *
     * @param object $obj The object to compare.
     * @return object
     */
    public function Equals(object $obj)
    {

    }

    // public void GetBaseValue()
    // {
    //     GetWrappedObject().GetBaseValue();
    // }


    /**
     * Gets the hash code for the object.
     *
     * @return int
     */
    public function GetHashCode()
    {

    }

    /**
     * Gets a AvaloniaProperty value.
     *
     * @param AvaloniaProperty $
     * @return mixed The value.
     */
    public function GetValue(/*AvaloniaProperty*/ $property)
    {

    }

    /**
     * Checks whether a AvaloniaProperty is animating.
     *
     * @param AvaloniaProperty $property
     * @return bool True if the property is animating, otherwise false.
     */
    public function IsAnimating(AvaloniaProperty $property)
    {

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
    /**
     *  Checks whether a AvaloniaProperty is set on this object.
     *  Checks whether a value is assigned to the property, or that there is a binding to the
     *  property that is producing a value other than AvaloniaProperty->UnsetValue.
     * @param AvaloniaProperty $property
     * @return bool
     */
    public function IsSet(AvaloniaProperty $property)
    {

    }

    /*
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
    */

    /// <summary>
    /// Checks that the current thread is the UI thread and throws if not.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// The current thread is not the UI thread.
    /// </exception>
    /**
     * Checks that the current thread is the UI thread and throws if not.
     *
     * @return void
     */
    public function VerifyAccess(): void
    {

    }
}