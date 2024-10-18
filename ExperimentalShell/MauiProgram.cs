using CommunityToolkit.Maui;
using ExperimentalShell.Models;
using ExperimentalShell.Services;
using ExperimentalShell.ViewModels;
using ExperimentalShell.Views;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;
using Telerik.Maui.Controls.Compatibility;
using ZXing.Net.Maui.Controls;
namespace ExperimentalShell
{
    public static class MauiProgram
    {
        public static event EventHandler ScanHandler;
        public static void OnScan(string source, string data, string labelType)
        {
            ScanResult scanResult = new()
            {
                Source = source,
                Data = data,
                LabelType = labelType
            };

            EventHandler handler = ScanHandler;

            handler?.Invoke(scanResult, EventArgs.Empty);
        }

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseTelerik()
                .UseBarcodeReader()
                .AddAudio()
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

            builder.Services.AddSingleton<TasksBlazorView>();
            builder.Services.AddSingleton<TasksViewModel>();

            return builder.Build();
        }
    }
}
