using System;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Themes.Fluent;
using Material.Colors;
using Material.Styles.Themes.Base;


namespace Peachpie.Avalonia.Platform;

public static class UxAppBuilderMinimalExtensions
{
    public static TAppBuilder UseFluentTheme<TAppBuilder>(this TAppBuilder builder, FluentThemeMode mode = FluentThemeMode.Light)
        where TAppBuilder : AppBuilderBase<TAppBuilder>, new()
    {
        return builder.AfterSetup(_ =>
            builder.Instance?.Styles.Add(new FluentTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}")) { Mode = mode }));
    }
    
    public static TAppBuilder UseMaterialTheme<TAppBuilder>(this TAppBuilder builder, BaseThemeMode mode = BaseThemeMode.Light , PrimaryColor primaryColor = PrimaryColor.Blue , SecondaryColor secondaryColor = SecondaryColor.LightGreen)
        where TAppBuilder : AppBuilderBase<TAppBuilder>, new()
    {
        return builder.AfterSetup(_ =>
            
            builder.Instance?.Styles.Add(new Material.Styles.Themes.MaterialTheme(new Uri($"avares://{System.Reflection.Assembly.GetExecutingAssembly().GetName()}"))
            {
                BaseTheme = mode, 
                PrimaryColor = primaryColor,
                SecondaryColor = secondaryColor
            }));
    }

#pragma warning disable CS8632 // Аннотацию для ссылочных типов, допускающих значения NULL, следует использовать в коде только в контексте аннотаций "#nullable".
    public static int StartWithClassicDesktopLifetime<T>(this T builder, Action<IClassicDesktopStyleApplicationLifetime> callback, string[]? args, ShutdownMode shutdownMode = ShutdownMode.OnLastWindowClose) where T : AppBuilderBase<T>, new()
#pragma warning restore CS8632 // Аннотацию для ссылочных типов, допускающих значения NULL, следует использовать в коде только в контексте аннотаций "#nullable".
    {
        var classicDesktopStyleApplicationLifetime = new ClassicDesktopStyleApplicationLifetime
        {
            Args = args,
            ShutdownMode = shutdownMode
        };

        builder.SetupWithLifetime(classicDesktopStyleApplicationLifetime);

        callback?.Invoke(classicDesktopStyleApplicationLifetime);

#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL, для параметра "args" в "int ClassicDesktopStyleApplicationLifetime.Start(string[] args)".
        return classicDesktopStyleApplicationLifetime.Start(args);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL, для параметра "args" в "int ClassicDesktopStyleApplicationLifetime.Start(string[] args)".
    }
}