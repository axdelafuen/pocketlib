using PocketLib.ViewModels;

namespace PocketLib;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
	}
}
