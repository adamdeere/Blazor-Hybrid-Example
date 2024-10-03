using BlazorHybridMessAround.ViewModels;

namespace BlazorHybridMessAround.Components.Views;

public partial class GotLandingPage : ContentPage
{
	public GotLandingPage(KingsLandingViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}