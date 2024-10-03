using BlazorHybridMessAround.Models.GoT;
using BlazorHybridMessAround.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BlazorHybridMessAround.ViewModels.GoT;

public partial class GotBooksViewModel(HttpDataService ds) : ObservableObject
{
    [ObservableProperty]
    public ObservableCollection<GotBooks> _books = [];
    

    public async Task OnInitailise()
    {
        string address = "https://anapioficeandfire.com/api/books";

        Books = await ds.GetListFromJson<GotBooks>(address);
    }
}
