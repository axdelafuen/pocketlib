using PocketLib.Models;
namespace PocketLib.Pages;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();
		BindingContext = new DetailsPageViewModel();
	}
}