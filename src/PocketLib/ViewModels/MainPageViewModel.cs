using System.Windows.Input;
using ViewModels;

namespace PocketLib.ViewModels;

public class MainPageViewModel : BindableObject
{
    private ManagerViewModel Mgr { get; set; }
    
    private NavigatorViewModel Nav { get; set; }
    
    public MainPageViewModel(NavigatorViewModel navigatorViewModel, ManagerViewModel managerViewModel)
    {
        GoToAndLoadCommand = new Command<String>(GoToAndLoadCommandExecute);
        Mgr = managerViewModel;
        Nav = navigatorViewModel;
    }

    public ICommand GoToAndLoadCommand { get; set; }
    
    private async void GoToAndLoadCommandExecute(String arg)
    {
        switch (arg)
        {
            case "ListPage":
                Mgr.GetBooksFromCollectionCommand.Execute(null);
                Nav.GoToNavigationCommand.Execute("ListPage");
                break;
        }
    }
}