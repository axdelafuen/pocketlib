using System.Windows.Input;

namespace PocketLib.ViewModels;

public class AuthorPageViewModel : ContentPage
{
    public AuthorPageViewModel()
    {
        GoBackCommand = new Command(GoBackCommandExecute);
    }

    public ICommand GoBackCommand { get; set; }

    private async void GoBackCommandExecute(object obj)
    {
        await Shell.Current.GoToAsync("..");
    }
}