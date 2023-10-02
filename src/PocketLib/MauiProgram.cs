using CommunityToolkit.Maui;
using The49.Maui.ContextMenu;
using Microsoft.Extensions.Logging;
using Model;
using PocketLib.Pages;
using PocketLib.ViewModels;
using StubLib;
using ViewModels;

namespace PocketLib;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseContextMenu()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("SF-Pro.ttf", "SF-Pro");
            });
		
		builder.Services.AddSingleton<NavigatorViewModel>()
						.AddSingleton<ILibraryManager, LibraryStub>()
						.AddSingleton<IUserLibraryManager, UserLibraryStub>()
						.AddSingleton<ManagerViewModel>()
						.AddSingleton<MainPage>()
						.AddSingleton<ListPage>()
						.AddSingleton<SearchPage>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
