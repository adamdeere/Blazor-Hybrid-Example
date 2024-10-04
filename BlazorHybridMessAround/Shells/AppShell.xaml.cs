using BlazorHybridMessAround.Components.Views;
using BlazorHybridMessAround.Components.Views.GoT;
using System.Windows.Input;

namespace BlazorHybridMessAround;

public partial class AppShell : Shell
{

    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));

        Routing.RegisterRoute(nameof(BooksPage), typeof(BooksPage));
        Routing.RegisterRoute(nameof(CharactersPage), typeof(CharactersPage));
        Routing.RegisterRoute(nameof(HousesPage), typeof(HousesPage));
        Routing.RegisterRoute(nameof(BookDetailPage), typeof(BookDetailPage));
    }
}