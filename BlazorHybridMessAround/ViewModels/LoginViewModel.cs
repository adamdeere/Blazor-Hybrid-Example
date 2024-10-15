using BlazorHybridMessAround.Components.Views;
using BlazorHybridMessAround.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Telerik.Maui.Controls;

namespace BlazorHybridMessAround.ViewModels;

public partial class LoginViewModel(NavigationService service) : ObservableObject
{
    [ObservableProperty]
    private string _errorText = "turned on";

    [ObservableProperty]
    private bool _isVisible = false;

    [ObservableProperty]
    private string _username = string.Empty;

    [ObservableProperty]
    private string _password = string.Empty;

    public RadDataForm LoginForm { get; set; }

    [RelayCommand]
    private async Task LoginClick(string lol)
    {
       
        if (LoginForm.CommitChanges())
        {
            IsVisible = true;
            ErrorText = $"{Username} {Password}";
             await service.GoToHomePage();
        }




    }

    [RelayCommand]
    private async Task ResetClick(string lol)
    {
        IsVisible = false;
        ErrorText = "lol";
        await service.GoToHomePage();
    }
}
