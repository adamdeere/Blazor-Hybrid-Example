using BlazorHybridMessAround.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BlazorHybridMessAround.ViewModels;

[QueryProperty("PwnedViewModel", "PwnedViewModel")]
public partial class PwnedDataViewModel : ObservableObject
{
    [ObservableProperty]
    private PwnedModel _pwnedViewModel;
}
