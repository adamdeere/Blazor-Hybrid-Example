using BlazorHybridMessAround.Components.Pages.Cards;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorHybridMessAround.ViewModels;

public partial class SectionViewModel : ObservableObject
{
    [ObservableProperty]
    private string _imageSource = "./images/checkbox_blank.svg";

    [ObservableProperty]
    private bool _isPopupOpen;

    [ObservableProperty]
    private bool _showContextMenu = false;

    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _description;

    [ObservableProperty]
    private bool _complete;

    [ObservableProperty]
    private int _sequence;

    public SectionCard Card;
    public event EventHandler CardClick;

    [RelayCommand]
    private void OpenContextMenuCommand()
    {
        IsPopupOpen = !IsPopupOpen;
    }

    public void RefreshContextMenu()
    {
        Task.Run(async () =>
        {
            while (Card == null)
            {
                await Task.Delay(50);
            }
            Card.RefreshContextMenu();
        });
    }

    public void OnCardClick(MouseEventArgs e)
    {
        EventHandler handler = CardClick;
        handler?.Invoke(this, e);
    }
    public void UpdateDisplay()
    {
        if (Card != null)
        {
            ImageSource = Complete ? "./images/checkbox.svg" : "./images/checkbox_blank.svg";
            Card.InvokeStateHasChanged();
        }
    }

    public void SetLoading(bool isLoading)
    {
        Task.Run(async () =>
        {
            while (Card == null)
            {
                await Task.Delay(50);
            }
            Card.SetLoading(isLoading);
        });
    }
}
