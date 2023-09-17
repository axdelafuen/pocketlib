using Microsoft.Maui.Controls.Handlers;
using Microsoft.Maui.Controls.Platform;
using System.Windows.Input;

namespace PocketLib.Models;

public class ListPageViewModel : BindableObject
{
	public ListPageViewModel()
	{
		GoBackCommand = new Command(GoBackCommandExecute);
        GoToDetailsCommand = new Command(GoToDetailsCommandExecute);
    }

    public ICommand GoBackCommand { get; set; }
    public ICommand GoToDetailsCommand { get; set; }

    private async void GoBackCommandExecute(object obj)
	{
        Console.WriteLine("HE HO");
		await Shell.Current.GoToAsync("..");
	}
    private async void GoToDetailsCommandExecute(object obj)
    {
        await Shell.Current.GoToAsync("DetailsPage");
    }

}