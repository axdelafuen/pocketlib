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
        AddBookToCollectionByIsbnCommand = new Command(AddBookToCollectionByIsbnCommandExecute);
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
    // Mgr.GetBooksFromCollectionCommand.Execute(null);
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
    
    public ICommand AddBookToCollectionByIsbnCommand{ get; set; }

    private async void AddBookToCollectionByIsbnCommandExecute()
    {
        string result = await Application.Current.MainPage.DisplayPromptAsync("Saisir l'ISBN (13)", "Pour ajouter un livre à la collection", "Ok", "Fermer");
        Mgr.AddBookToCollectionByIsbnCommand.Execute(result);
    }
}