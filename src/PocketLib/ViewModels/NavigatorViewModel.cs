using System.Windows.Input;

namespace PocketLib.ViewModels;

public class NavigatorViewModel : BindableObject
{
    public NavigatorViewModel()
    {
        GoToNavigationCommand = new Command(GoToNavigationCommandExecute);
    }

    public ICommand GoToNavigationCommand { get; set; }

    private async void GoToNavigationCommandExecute(object obj)
    {
        await (Application.Current as App)!.MainPage!.Navigation.PushAsync(obj as Page); 
    }
}