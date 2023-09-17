using PocketLib.Pages;
using System.Windows.Input;
namespace PocketLib.Models;

public class MainPageViewModel : BindableObject
{
	public MainPageViewModel()
	{
        GoToTousCommand = new Command(GoToTousCommandExecute);
        GoToAuthorCommand = new Command(GoToAuthorCommandExecute);
        GoToDateCommand = new Command(GoToDateCommandExecute);
        //GoToEnPretCommand = new Command(GoToEnPretCommandExecute);
    }

    public ICommand GoToTousCommand { get; set; }
    public ICommand GoToAuthorCommand { get; set; }
    public ICommand GoToDateCommand { get; set; }
    public ICommand GoToEnPretCommand { get; set; }



    private async void GoToTousCommandExecute(object obj)
    {
        await Shell.Current.GoToAsync("ListPage");
    }
    private async void GoToAuthorCommandExecute(object obj)
    {
        await Shell.Current.GoToAsync("AuthorPage");
    }
    private async void GoToDateCommandExecute(object obj)
    {
       await Shell.Current.GoToAsync("DatePage");
    }

    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        MenuFlyoutItem menutItem = sender as MenuFlyoutItem;
    }

}