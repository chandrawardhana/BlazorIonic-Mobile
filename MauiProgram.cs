﻿using Microsoft.AspNetCore.Components.WebView.Maui;
using Blazor.Ionic;



namespace BlazorIonic;

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

		builder.Services.AddSingleton<UIStateService>();
		

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		
#endif

		

		return builder.Build();
	}
}

