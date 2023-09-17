using PocketLib.Models;
namespace PocketLib.Pages;

public partial class DatePage : ContentPage
{
	public DatePage()
	{
		InitializeComponent();
		BindingContext = new DatePageViewModel();
	}
}