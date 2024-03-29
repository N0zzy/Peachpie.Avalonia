﻿#nullable enable
using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Material.Colors;
using Material.Styles.Themes;
using Material.Styles.Themes.Base;
using Peachpie.Avalonia.Controls;


namespace Peachpie.Avalonia.Platform;

public class UxApplication
{
    public UxApplication(Closure closure, string[]? args = null)
    {
        var lifetime = new ClassicDesktopStyleApplicationLifetime
            { Args = args, ShutdownMode = ShutdownMode.OnLastWindowClose };

        AppBuilder.Configure<Application>()
            .UsePlatformDetect()
            .AfterSetup(b => b.Instance?.Styles.Add(
                new MaterialTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}"))
                {
                    BaseTheme = BaseThemeMode.Dark,
                    PrimaryColor = PrimaryColor.LightBlue,
                    SecondaryColor = SecondaryColor.Blue
                }))
            .SetupWithLifetime(lifetime);
        var w = (UxWindow) closure.__invoke().ToClass();
        lifetime.MainWindow = w.WrappedObject;

        lifetime.Start(args);
    }
    
}

