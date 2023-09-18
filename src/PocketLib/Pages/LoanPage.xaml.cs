using PocketLib.ViewModels;
namespace PocketLib.Pages;

public partial class LoanPage : ContentPage
{
	public LoanPage()
	{
		InitializeComponent();
		BindingContext = new LoanPageViewModel();
	}
}