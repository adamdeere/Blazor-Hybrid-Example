using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExperimentalShell.Services;
using Telerik.Maui.Controls;
using Telerik.SvgIcons;

namespace ExperimentalShell.ViewModels;

public partial class LoginViewModel(NavigationService service) : BaseViewModel
{
    [ObservableProperty]
    private string _username = string.Empty;

    [ObservableProperty]
    private string _password = string.Empty;

    public RadDataForm? LoginForm { get; set; }

    [RelayCommand]
    private async Task LoginClick(string lol)
    {
        if (LoginForm != null)
        {
            if (LoginForm.CommitChanges())
            {
                //Error = $"{Username} {Password}";
                await service.GoToHomePage();
            }
        }
        else
        {
            await service.GoToHomePage();
        }
       




    }
}
