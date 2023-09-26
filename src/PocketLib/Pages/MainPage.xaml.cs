using PocketLib.ViewModels;
namespace PocketLib.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new NavigatorViewModel();
    }
}

