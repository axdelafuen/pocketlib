using System.Windows.Input;
using ViewModels;

namespace PocketLib.ViewModels;

public class MainPageViewModel : BindableObject
{
    public ManagerViewModel Mgr { get; set; }
    
    private NavigatorViewModel Nav { get; set; }
    
    public MainPageViewModel(NavigatorViewModel navigatorViewModel, ManagerViewModel managerViewModel)
    {
        GoToAndLoadCommand = new Command<String>(GoToAndLoadCommandExecute);
        AddBookToCollectionByIsbnCommand = new Command(AddBookToCollectionByIsbnCommandExecute);
        Mgr = managerViewModel;
        Nav = navigatorViewModel;
    }

    public ICommand GoToAndLoadCommand { get; set; }
    
    private async void GoToAndLoadCommandExecute(String arg)
    {
        switch (arg)
        {
            case "Tous":
                Mgr.GetBooksFromCollectionCommand.Execute(null);
                Nav.GoToNavigationCommand.Execute("ListPage");
                Mgr.PageTitle = "Tous";
                break;
            case "PretPage":
                Nav.GoToNavigationCommand.Execute("LoanPage");
                Mgr.PageTitle = "En prêt";
                break;
            case "ALirePlusTardPage":
                Mgr.GetToBeReadBooksCommand.Execute(null);
                Nav.GoToNavigationCommand.Execute("ListPage");
                Mgr.PageTitle = "À lire plus tard";
                break;
            case "StatusPage":
                Nav.GoToNavigationCommand.Execute("TempPage");
                Mgr.PageTitle = "Statut de lecture";
                break;
            case "AuteurPage":
                Nav.GoToNavigationCommand.Execute("AuthorPage");
                break;
            case "DatePage":
                Nav.GoToNavigationCommand.Execute("DatePage");
                break;
            default:
                Nav.GoToNavigationCommand.Execute("TempPage");
                break;
        }
    }
    
    public ICommand AddBookToCollectionByIsbnCommand{ get; set; }

    private async void AddBookToCollectionByIsbnCommandExecute()
    {
        string result = await Application.Current.MainPage.DisplayPromptAsync("Saisir l'ISBN (13)", "Pour ajouter un livre à la collection", "Ok", "Fermer");
        Mgr.AddBookToCollectionByIsbnCommand.Execute(result);
    }
    
}