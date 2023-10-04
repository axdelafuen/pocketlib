using System.Windows.Input;
using PocketLib.Pages;

namespace PocketLib.ViewModels;

public class NavigatorViewModel : BindableObject
{
    public NavigatorViewModel()
    {
        GoToNavigationCommand = new Command<String>(GoToNavigationCommandExecute);
    }

    public ICommand GoToNavigationCommand { get; set; }
    
    private async void GoToNavigationCommandExecute(String arg)
    {
        switch (arg)
        {
            case "ListPage_Tous":
                //await Application.Current!.MainPage!.Navigation.PushAsync());
                // FAIRE PASSER UNE LIST PAGE 
                break;
        }
    }
}