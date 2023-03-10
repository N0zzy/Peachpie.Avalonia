﻿using Avalonia.Controls;

namespace Peachpie.Avalonia.Controls;

/// <summary>
/// Defines how a <see cref="UxButton"/> reacts to clicks.
/// </summary>
public enum ClickMode
{
    Release,
    Press
}

public class UxButton<T> : UxContentControl<T> where T : Button, new()
{
    
    /// <summary>
    /// Gets or sets a value indicating how the <see cref="Button"/> should react to clicks.
    /// </summary>
    public ClickMode ClickMode
    {
        get => (ClickMode)GetWrappedObject().ClickMode;
        set => GetWrappedObject().ClickMode = (global::Avalonia.Controls.ClickMode) value;
    }
}

public class UxButton : UxButton<Button>
{
    
}