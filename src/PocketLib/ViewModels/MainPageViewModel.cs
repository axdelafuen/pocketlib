using PocketLib.Pages;
using System.Windows.Input;
namespace PocketLib.ViewModels;

public class MainPageViewModel : BindableObject
{
	public MainPageViewModel()
	{
        GoToListCommand = new Command(GoToListCommandExecute);
        GoToAuthorCommand = new Command(GoToAuthorCommandExecute);
        GoToDateCommand = new Command(GoToDateCommandExecute);
        GoToNoteCommand = new Command(GoToNoteCommandExecute);
        GoToLoanCommand = new Command(GoToLoanCommandExecute);
    }

    public ICommand GoToListCommand { get; set; }
    public ICommand GoToAuthorCommand { get; set; }
    public ICommand GoToDateCommand { get; set; }
    public ICommand GoToEnPretCommand { get; set; }
    public ICommand GoToNoteCommand { get; set; }
    public ICommand GoToLoanCommand { get; set; }

    private async void GoToListCommandExecute(object obj)
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

    private async void GoToNoteCommandExecute(object obj)
    {
        await Shell.Current.GoToAsync("NotePage");
    }
    private async void GoToLoanCommandExecute(object obj)
    {
        await Shell.Current.GoToAsync("LoanPage");
    }
    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        MenuFlyoutItem menutItem = sender as MenuFlyoutItem;
    }

}