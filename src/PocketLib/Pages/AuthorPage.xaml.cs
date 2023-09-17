using PocketLib.Models;
namespace PocketLib.Pages;

public partial class AuthorPage : ContentPage
{
	public AuthorPage()
	{
		InitializeComponent();
		BindingContext = new AuthorPageViewModel();
	}
}