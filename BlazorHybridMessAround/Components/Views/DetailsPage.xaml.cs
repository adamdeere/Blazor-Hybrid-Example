using BlazorHybridMessAround.ViewModels;

namespace BlazorHybridMessAround.Components.Views;


public partial class DetailsPage : ContentPage
{
    public DetailsPage(PwnedDataViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}