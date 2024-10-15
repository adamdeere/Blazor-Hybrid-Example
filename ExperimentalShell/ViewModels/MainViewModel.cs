using CommunityToolkit.Mvvm.Input;
using ExperimentalShell.Services;

namespace ExperimentalShell.ViewModels;

public partial class MainViewModel(NavigationService service) : BaseViewModel
{
    [RelayCommand]
    private async Task ViewAnimal(Type type)
    {
        await service.GoToPage(type.Name);
    }
}
