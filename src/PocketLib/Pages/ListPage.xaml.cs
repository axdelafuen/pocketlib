using PocketLib.ViewModels;
using ViewModels;

namespace PocketLib.Pages;

public partial class ListPage : ContentPage
{
	public NavigatorViewModel nav { get; set; }
	public ManagerViewModel mgr { get; set; }
	public ListPage(NavigatorViewModel navigatorViewModel, ManagerViewModel managerViewModel)
	{
		nav = navigatorViewModel;
		mgr = managerViewModel;
		mgr.GetBooksFromCollectionCommand.Execute(null);
		InitializeComponent();
		BindingContext = this;
	}
}