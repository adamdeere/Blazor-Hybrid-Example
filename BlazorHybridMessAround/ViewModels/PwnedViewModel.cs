using BlazorHybridMessAround.Models;
using BlazorHybridMessAround.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BlazorHybridMessAround.ViewModel;

public partial class PwnedViewModel(HttpDataService ds) : ObservableObject
{
    private readonly HttpDataService _dataService = ds;
    private bool IsBusy;

    [ObservableProperty]
    public ObservableCollection<PwnedModel> _pwned = [];

    public async Task OnInitailise()
    {
        string address = "https://haveibeenpwned.com/api/v2/breaches";

        Pwned = await _dataService.GetListFromJson<PwnedModel>(address);
    }


}
