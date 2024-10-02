using BlazorHybridMessAround.ViewModels;

namespace BlazorHybridMessAround.Components.Views;

public partial class LoginView : ContentPage
{
	public LoginView(LoginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}