namespace BlazorHybridMessAround.Services;

public class NavigationService
{
    public async Task GoToPage<T>()
    {
        await Shell.Current.GoToAsync($"//{typeof(T).Name}");
    }
   
}
