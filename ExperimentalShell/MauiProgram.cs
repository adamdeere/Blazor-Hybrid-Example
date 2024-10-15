using CommunityToolkit.Maui;
using ExperimentalShell.Services;
using ExperimentalShell.ViewModels;
using ExperimentalShell.Views;
using Microsoft.Extensions.Logging;
using Telerik.Maui.Controls.Compatibility;

namespace ExperimentalShell
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseTelerik()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<NavigationService>();
            builder.Services.AddSingleton<HttpService>();

            builder.Services.AddTransient<LoginView>();
            builder.Services.AddTransient<LoginViewModel>();

            builder.Services.AddSingleton<MainView>();
            builder.Services.AddSingleton<MainViewModel>();

            return builder.Build();
        }
    }
}
