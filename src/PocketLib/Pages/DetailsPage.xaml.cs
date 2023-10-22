using PocketLib.ViewModels;
using ViewModels;

namespace PocketLib.Pages;

public partial class DetailsPage : ContentPage
{
	public DetailsPageViewModel detailsVM{  get; set; }
	public DetailsPage(ManagerViewModel managerViewModel)
	{
		detailsVM = new DetailsPageViewModel(managerViewModel);
		InitializeComponent();
		BindingContext = this;
	}
}