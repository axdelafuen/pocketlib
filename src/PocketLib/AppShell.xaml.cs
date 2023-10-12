﻿using PocketLib.ViewModels;

namespace PocketLib;
using PocketLib.Pages;

public partial class AppShell : Shell
{
	public AppShell()
	{
		Routing.RegisterRoute("ListPage", typeof(ListPage));
		Routing.RegisterRoute("DetailsPage", typeof(DetailsPage));
		InitializeComponent();
    }
}
