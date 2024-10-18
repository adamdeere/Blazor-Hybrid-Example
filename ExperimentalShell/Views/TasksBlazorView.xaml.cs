using ExperimentalShell.ViewModels;

namespace ExperimentalShell.Views;

public partial class TasksBlazorView : ContentPage
{
	public TasksBlazorView(TasksViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}