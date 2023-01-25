#nullable enable
using Avalonia;
using Avalonia.Controls;
using Material.Styles.Themes.Base;


namespace Peachpie.Avalonia.Platform;

public class UxApplication
{
    public UxApplication(Closure closure, string materialThemeMode , string[]? args = null)
    {
        var builder =  AppBuilder.Configure<Application>();
            builder.UsePlatformDetect();
            
            switch (materialThemeMode)
            {
                case "Dark":
                    UxAppBuilderMinimalExtensions.UseMaterialTheme(builder, mode: BaseThemeMode.Dark);
                    break;
                case "Light":
                    UxAppBuilderMinimalExtensions.UseMaterialTheme(builder, mode: BaseThemeMode.Light);
                    break;
                case "Inherit":
                    UxAppBuilderMinimalExtensions.UseMaterialTheme(builder, mode: BaseThemeMode.Inherit);
                    break;
                default:
                    UxAppBuilderMinimalExtensions.UseMaterialTheme(builder, mode: BaseThemeMode.Dark);
                    break;
            }
            
            builder.StartWithClassicDesktopLifetime(desktop =>
            {
                desktop.MainWindow = (Window) closure.__invoke().ToClass();
            }, args );
    }
}