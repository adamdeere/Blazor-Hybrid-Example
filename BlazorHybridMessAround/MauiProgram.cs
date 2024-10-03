using BlazorHybridMessAround.Components.Views;
using BlazorHybridMessAround.Components.Views.GoT;
using BlazorHybridMessAround.Services;
using BlazorHybridMessAround.ViewModel;
using BlazorHybridMessAround.ViewModels;
using BlazorHybridMessAround.ViewModels.GoT;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Telerik.Maui.Controls.Compatibility;

namespace BlazorHybridMessAround
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
            // register the Telerik services
            builder.Services.AddTelerikBlazor();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<NavigationService>();
            builder.Services.AddTransient<HttpDataService>();

            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<LoginViewModel>();

            builder.Services.AddSingleton<PwnedViewModel>();

            builder.Services.AddTransient<DetailsPage>();
            builder.Services.AddTransient<PwnedDataViewModel>();

            builder.Services.AddTransient<GotLandingPage>();
            builder.Services.AddTransient<KingsLandingViewModel>();
         
            builder.Services.AddTransient<GotBooksViewModel>();
            return builder.Build();
        }
    }
}