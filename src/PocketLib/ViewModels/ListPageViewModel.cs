using System.Runtime.InteropServices;
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
        PrevPageCommand = new Command(PrevPageCommandExecute);
        NextPageCommand = new Command(NextPageCommandExecute);
        Mgr = managerViewModel;
        Nav = navigatorViewModel;
    }

    public ICommand GoToAndLoadCommand { get; set; }
    
    public ICommand PrevPageCommand { get; set; }
    
    public ICommand NextPageCommand { get; set; }

    private async void GoToAndLoadCommandExecute()
    {
        Nav.GoToNavigationCommand.Execute("DetailsPage");
    }
    
    private void PrevPageCommandExecute()
    {
        if (Mgr.Index > 0)
        {
            Mgr.Index--;
        }
    }

    private void NextPageCommandExecute()
    {
        if (Mgr.Index < Mgr.NbPages)
        {
            Mgr.Index++;
        }
    }
}