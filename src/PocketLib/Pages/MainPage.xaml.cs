using PocketLib.ViewModels;
using ViewModels;

namespace PocketLib.Pages;

public partial class MainPage : ContentPage
{
    public NavigatorViewModel Nav { get; set; }
    public ManagerViewModel Mgr { get; set; }
    public MainPage(NavigatorViewModel navigatorViewModel, ManagerViewModel managerViewModel)
    {
        Nav = navigatorViewModel;
        Mgr = managerViewModel;
        InitializeComponent();
        BindingContext = this;
    }
}

