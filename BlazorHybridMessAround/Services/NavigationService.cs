namespace BlazorHybridMessAround.Services;

class NavigationService
{
    public async void GoToPage<T>()
    {
        var r = typeof(T);
        await Shell.Current.GoToAsync(r.Name);
    }
}
