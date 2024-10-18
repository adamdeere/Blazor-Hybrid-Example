using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExperimentalShell.ViewModels;

public partial class TasksViewModel() : BaseViewModel
{
    [ObservableProperty]
    private string _headerText = "Tasks page";

#if ANDROID

    [ObservableProperty]
    private bool _isRefreshing;

    [RelayCommand]
    private void Refresh()
    {
        IsRefreshing = true;
        //tasksList?.LoadData();
        IsRefreshing = false;
    }
#endif
}
