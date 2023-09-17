using PocketLib.Models;

namespace PocketLib.Pages;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
		BindingContext = new ListPageViewModel();
	}
}