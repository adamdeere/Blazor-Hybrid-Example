using ExperimentalShell.Views;

namespace ExperimentalShell.Services;

public class NavigationService
{
    public async Task GoToHomePage()
    {
        await Shell.Current.GoToAsync($"//{nameof(TasksBlazorView)}");
    }

    public async Task GoToPage<T>()
    {
        await Shell.Current.GoToAsync($"{typeof(T).Name}");
    }
    public async Task GoToPage(string name)
    {
        await Shell.Current.GoToAsync($"{name}");
    }
}
