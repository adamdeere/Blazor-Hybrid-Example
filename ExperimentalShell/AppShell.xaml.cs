using System.Windows.Input;

namespace ExperimentalShell;

public partial class AppShell : Shell
{
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }
}