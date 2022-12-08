#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Themes.Fluent;

namespace Peachpie.Avalonia.Platform;

public class UxApplication
{
    public UxApplication(Closure closure, string fluentThemeMode , string[]? args = null)
    {
        var builder =  AppBuilder.Configure<Application>();
            builder.UsePlatformDetect();
            
            switch (fluentThemeMode)
            {
                case "Dark":
                    UxAppBuilderMinimalExtensions.UseFluentTheme(builder, mode: FluentThemeMode.Dark);
                    break;
                case "Light":
                    UxAppBuilderMinimalExtensions.UseFluentTheme(builder, mode: FluentThemeMode.Light);
                    break;
                default:
                    UxAppBuilderMinimalExtensions.UseFluentTheme(builder, mode: FluentThemeMode.Light);
                    break;
            }
            
            builder.StartWithClassicDesktopLifetime(desktop =>
            {
                desktop.MainWindow = (Window) closure.__invoke().ToClass();
            }, args );
    }
}