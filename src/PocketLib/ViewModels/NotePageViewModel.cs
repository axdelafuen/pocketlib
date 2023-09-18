using System.Windows.Input;

namespace PocketLib.ViewModels;

public class NotePageViewModel : ContentPage
{

    public NotePageViewModel()
    {
        GoBackCommand = new Command(GoBackCommandExecute);
    }

    public ICommand GoBackCommand { get; set; }

    private async void GoBackCommandExecute(object obj)
    {
        await Shell.Current.GoToAsync("..");
    }
}