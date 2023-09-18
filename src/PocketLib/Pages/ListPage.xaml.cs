using PocketLib.ViewModels;
namespace PocketLib.Pages;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
		BindingContext = new ListPageViewModel();
	}
}