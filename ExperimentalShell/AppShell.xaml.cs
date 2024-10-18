using ExperimentalShell.Views;
using ExperimentalShell.Views.Dogs;
using System.Windows.Input;

namespace ExperimentalShell;

public partial class AppShell : Shell
{
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(TasksBlazorView), typeof(TasksBlazorView));
        Routing.RegisterRoute(nameof(DogsView), typeof(DogsView));
    }
}