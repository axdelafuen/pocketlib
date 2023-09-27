using PocketLib.ViewModels;
namespace PocketLib.Pages;

public partial class MainPage : ContentPage
{
    public NavigatorViewModel nav { get; set; }
    public MainPage(NavigatorViewModel navigatorViewModel)
    {
        nav = navigatorViewModel;
        InitializeComponent();
        BindingContext = this;
    }
}

