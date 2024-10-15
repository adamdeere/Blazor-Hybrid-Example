using CommunityToolkit.Mvvm.ComponentModel;

namespace BlazorHybridMessAround.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool _isBusy = true;

    [ObservableProperty]
    private bool _isLoading = true;

    [ObservableProperty]
    private bool _error;
}
