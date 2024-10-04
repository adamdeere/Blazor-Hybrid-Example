using BlazorHybridMessAround.ViewModels.GoT;

namespace BlazorHybridMessAround.Components.Views.GoT;

public partial class BookDetailPage : ContentPage
{
    public BookDetailPage(BookDetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}