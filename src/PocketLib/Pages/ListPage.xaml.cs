using PocketLib.ViewModels;
using ViewModels;

namespace PocketLib.Pages;

public partial class ListPage : ContentPage
{
	public ListPageViewModel ListPageVM { get; set; }
	public ListPage(NavigatorViewModel navigatorViewModel, ManagerViewModel managerViewModel)
	{
		ListPageVM = new ListPageViewModel(navigatorViewModel, managerViewModel); 
		InitializeComponent();
		BindingContext = this;
	}
	
	// A mettre dans la VM (je ne sais pas comment faire)
	public void SelectableItemsView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.Count > 0)
		{
			ListPageVM.Mgr.SelectedBook = (e.CurrentSelection[0] as BookViewModel);
			ListPageVM.GoToAndLoadCommand.Execute(null);
			(sender as CollectionView).SelectedItem = null; 
		}
	}
}