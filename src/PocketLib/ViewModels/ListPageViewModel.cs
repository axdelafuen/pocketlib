using System.Windows.Input;
using ViewModels;

namespace PocketLib.ViewModels;

public class ListPageViewModel
{
    public ManagerViewModel Mgr { get; set; }
    
    private NavigatorViewModel Nav { get; set; }
    
    public ListPageViewModel(NavigatorViewModel navigatorViewModel, ManagerViewModel managerViewModel)
    {
        GoToAndLoadCommand = new Command(GoToAndLoadCommandExecute);
        Mgr = managerViewModel;
        Nav = navigatorViewModel;
    }

    public ICommand GoToAndLoadCommand { get; set; }

    private async void GoToAndLoadCommandExecute()
    {
        //Mgr.GetBookByIdCommand.Execute(Id);
        Nav.GoToNavigationCommand.Execute("DetailsPage");
    }
}