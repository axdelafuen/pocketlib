using PocketLib.ViewModels;
namespace PocketLib.Pages;

public partial class MainPage : ContentPage
{
    public NavigatorViewModel Nav { get; set; }
    public MainPage(NavigatorViewModel navigatorViewModel)
    {
        Nav = navigatorViewModel;
        InitializeComponent();
        BindingContext = this;
    }
}

