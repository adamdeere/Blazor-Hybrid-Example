using BlazorHybridMessAround.Models;
using BlazorHybridMessAround.Services;
using BlazorHybridMessAround.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BlazorHybridMessAround.ViewModel;

public partial class PwnedViewModel(HttpDataService ds) : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<PwnedModel> _pwned = [];



    public async Task OnInitailise()
    {
        IsBusy = true;
        string address = "https://haveibeenpwned.com/api/v2/breaches";

        Pwned = await ds.GetListFromJson<PwnedModel>(address);
        for (int i = 0; i < 2; i++)
        {
             for (int j = 0; j < 250; j++)
             {
                 Pwned?.RemoveAt(j);
             }
        }
        IsBusy = false;
    }


}
