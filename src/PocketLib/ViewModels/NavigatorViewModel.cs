using System.Windows.Input;
using PocketLib.Pages;
using ViewModels;

namespace PocketLib.ViewModels;

public class NavigatorViewModel : BindableObject
{
    public NavigatorViewModel(ManagerViewModel managerViewModel)
    {
        GoToNavigationCommand = new Command<String>(GoToNavigationCommandExecute);
    }

    public ICommand GoToNavigationCommand { get; set; }
    
    private async void GoToNavigationCommandExecute(String arg)
    {
        await Shell.Current.GoToAsync(arg);
    }
}