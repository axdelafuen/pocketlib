using PocketLib.ViewModels;
using ViewModels;

namespace PocketLib.Pages;

public partial class ListPage : ContentPage
{
	public NavigatorViewModel Nav { get; set; }
	public ManagerViewModel Mgr { get; set; }
	public ListPage(NavigatorViewModel navigatorViewModel, ManagerViewModel managerViewModel)
	{
		Nav = navigatorViewModel;
		Mgr = managerViewModel;
		InitializeComponent();
		BindingContext = this;
	}
}