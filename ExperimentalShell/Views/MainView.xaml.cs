using ExperimentalShell.ViewModels;

namespace ExperimentalShell.Views;

public partial class MainView : ContentPage
{
	public MainView(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}