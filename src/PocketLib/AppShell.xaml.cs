﻿namespace PocketLib;
using PocketLib.Pages;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(TempPage), typeof(TempPage));
        Routing.RegisterRoute(nameof(ListPage), typeof(ListPage));
        Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        Routing.RegisterRoute(nameof(DatePage), typeof(DatePage));
        Routing.RegisterRoute(nameof(AuthorPage), typeof(AuthorPage));
    }
}
