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

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		ListPageVM.Mgr.selectedBook = (e.CurrentSelection.FirstOrDefault() as BookViewModel);
    }
}