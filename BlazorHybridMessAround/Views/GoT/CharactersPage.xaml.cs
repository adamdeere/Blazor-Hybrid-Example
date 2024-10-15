using BlazorHybridMessAround.ViewModels.GoT;

namespace BlazorHybridMessAround.Components.Views.GoT;

public partial class CharactersPage : ContentPage
{
	public CharactersPage(CharacterViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private void tabView_SelectionChanged(object sender, EventArgs e)
    {
		
    }
}