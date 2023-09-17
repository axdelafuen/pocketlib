using System.Windows.Input;
using PocketLib.Models;
namespace PocketLib.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}

