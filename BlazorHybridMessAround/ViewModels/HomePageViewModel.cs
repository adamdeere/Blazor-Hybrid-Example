using BlazorHybridMessAround.Models;
using CommunityToolkit.Mvvm.Input;

namespace BlazorHybridMessAround.ViewModels;

public partial class HomePageViewModel : BaseViewModel
{
    [RelayCommand]
    private void TapClick(PwnedModel k)
    {
        int i = 0;
        i++;
    }
}
