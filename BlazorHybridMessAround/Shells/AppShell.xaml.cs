using BlazorHybridMessAround.Components.Pages;
using BlazorHybridMessAround.Components.Views;

namespace BlazorHybridMessAround;

public partial class AppShell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
    }
}