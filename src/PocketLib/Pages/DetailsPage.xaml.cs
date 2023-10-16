using PocketLib.ViewModels;
using ViewModels;

namespace PocketLib.Pages;

public partial class DetailsPage : ContentPage
{
	DetailsPageViewModel detailsVM{  get; set; }
	public DetailsPage(ManagerViewModel managerViewModel)
	{
		detailsVM = new DetailsPageViewModel(managerViewModel);
		InitializeComponent();
		BindingContext = detailsVM;
	}
}