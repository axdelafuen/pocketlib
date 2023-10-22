using PocketLib.ViewModels;
using ViewModels;

namespace PocketLib.Pages;

public partial class MainPage : ContentPage
{
    public MainPageViewModel MainPageVM { get; set; }
    public MainPage(NavigatorViewModel navigatorViewModel, ManagerViewModel managerViewModel)
    {
        MainPageVM = new MainPageViewModel(navigatorViewModel, managerViewModel);
        InitializeComponent();
        BindingContext = this;
    }
}

