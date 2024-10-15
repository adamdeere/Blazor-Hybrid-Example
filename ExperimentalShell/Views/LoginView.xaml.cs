using ExperimentalShell.ViewModels;

namespace ExperimentalShell.Views;

public partial class LoginView : ContentPage
{
	public LoginView(LoginViewModel vm)
	{
		InitializeComponent();
        vm.LoginForm = LoginForm;
        BindingContext = vm;
    }
}