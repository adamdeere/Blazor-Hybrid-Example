using BlazorHybridMessAround.Models.GoT;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorHybridMessAround.ViewModels.GoT;

[QueryProperty("BookItem", "BookItem")]
public partial class BookDetailViewModel : ObservableObject
{
    [ObservableProperty]
    GotBooks _bookItem;
}
