using System.Windows.Input;
using PocketLib.Pages;
using ViewModels;

namespace PocketLib.ViewModels;

public class NavigatorViewModel : BindableObject
{
    private ManagerViewModel Mgr { get; set; }
    public NavigatorViewModel(ManagerViewModel managerViewModel)
    {
        GoToNavigationCommand = new Command<String>(GoToNavigationCommandExecute);
        Mgr = managerViewModel;
    }

    public ICommand GoToNavigationCommand { get; set; }
    
    private async void GoToNavigationCommandExecute(String arg)
    {
        switch (arg)
        {
            case "ListPage_Tous":
                await Shell.Current.GoToAsync(nameof(ListPage));
                Mgr.GetBooksFromCollectionCommand.Execute(null);
                break;
        }
    }
}