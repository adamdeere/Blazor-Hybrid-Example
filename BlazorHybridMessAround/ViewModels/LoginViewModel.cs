using BlazorHybridMessAround.Components.Views;
using BlazorHybridMessAround.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BlazorHybridMessAround.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    private NavigationService _navigationService;// { get; set; }
    public LoginViewModel(NavigationService service)
    {
       _navigationService = service;
    }
    [RelayCommand]
    private async Task LoginClick()
    {
        await _navigationService.GoToPage<HomeView>();
    }
}
