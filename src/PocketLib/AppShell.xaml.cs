using PocketLib.ViewModels;

namespace PocketLib;
using PocketLib.Pages;

public partial class AppShell : Shell
{
	public AppShell()
	{
		Routing.RegisterRoute("ListPage", typeof(ListPage));
		Routing.RegisterRoute("DetailsPage", typeof(DetailsPage));
		Routing.RegisterRoute("TempPage", typeof(TempPage));
		Routing.RegisterRoute("LoanPage", typeof(LoanPage));
		Routing.RegisterRoute("AuthorPage", typeof(AuthorPage));
		Routing.RegisterRoute("DatePage", typeof(DatePage));
		InitializeComponent();
    }
}
