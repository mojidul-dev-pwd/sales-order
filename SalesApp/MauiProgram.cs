using Microsoft.AspNetCore.Components.WebView.Maui;
using SalesApp.BLL;
using SalesApp.DAL;
using SalesApp.Data;

namespace SalesApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddSingleton<IElementService, ElementServiceImpl>();
        builder.Services.AddSingleton<IElementRepo, ElementRepoImpl>();

        return builder.Build();
	}
}
