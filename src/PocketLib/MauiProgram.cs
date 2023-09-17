using CommunityToolkit.Maui;
using The49.Maui.ContextMenu;
using Microsoft.Extensions.Logging;
using PocketLib.Pages;
using PocketLib.Models;

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
        builder.Services.AddScoped<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();

        builder.Services.AddScoped<ListPage>();
        builder.Services.AddTransient<ListPageViewModel>();
        
        builder.Services.AddScoped<DetailsPage>();
        builder.Services.AddTransient<DetailsPageViewModel>();

        builder.Services.AddScoped<AuthorPage>();
        builder.Services.AddTransient<AuthorPageViewModel>();

        builder.Services.AddScoped<DatePage>();
        builder.Services.AddTransient<DatePageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
