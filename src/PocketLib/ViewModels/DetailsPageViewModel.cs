using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Model;
using System.Windows.Input;
using ViewModels;

namespace PocketLib.ViewModels;

public class DetailsPageViewModel
{
    public ManagerViewModel Mgr { get; set; }

    public DetailsPageViewModel(ManagerViewModel managerViewModel)
    {
        ChangeStatusCommand = new Command(ChangeStatusCommandExecute);
        Mgr = managerViewModel;
    }

    public ICommand ChangeStatusCommand { get; set; }

    private async void ChangeStatusCommandExecute()
    {
        string status = await Application.Current.MainPage.DisplayActionSheet("Changer le statut de lecture", "Retour", null, "À lire", "En lecture", "Non lu", "Terminé");
        if (status != null)
        {
            switch (status)
            {
                case "À lire":
                    // Change status of the book to A lire
                    break;
                case "En lecture":
                    break;
                case "Non lu":
                    break;
                case "Terminé":
                    break;
                default:
                    break;
            }

            _ = Toast.Make("Changement du status: " + Mgr.SelectedBook.Status.ToString(), ToastDuration.Short, 14).Show(new CancellationTokenSource().Token);
        }
        else
        {
            _ = Toast.Make("Changement du status: erreur, pas de changement", ToastDuration.Short, 14).Show(new CancellationTokenSource().Token);
        }
    }

}