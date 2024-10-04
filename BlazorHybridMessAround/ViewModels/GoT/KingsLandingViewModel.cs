using BlazorHybridMessAround.Components.Views.GoT;
using BlazorHybridMessAround.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BlazorHybridMessAround.ViewModels;

public partial class KingsLandingViewModel(NavigationService service) : ObservableObject
{
    [RelayCommand]
    private async Task GoToBooks(Type type)
    {
        var t = type.GetType();
        await service.GoToPage(type.Name);
    }
}
