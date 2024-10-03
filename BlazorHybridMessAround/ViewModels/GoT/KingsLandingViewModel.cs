using BlazorHybridMessAround.Components.Views.GoT;
using BlazorHybridMessAround.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BlazorHybridMessAround.ViewModels;

public partial class KingsLandingViewModel(NavigationService service) : ObservableObject
{
    private readonly NavigationService _navigationService = service;

    [RelayCommand]
    private async Task GoToBooks(string y)
    {
        await _navigationService.GoToPage(y);
    }
}
