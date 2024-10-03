using BlazorHybridMessAround.ViewModels;

namespace BlazorHybridMessAround.Components.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}