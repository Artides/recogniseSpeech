namespace RecognizeSpeech;

using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using RecognizeSpeech.Pages;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit();

		//-- Services
		builder.Services.AddSingleton(TextToSpeech.Default);
		builder.Services.AddSingleton(Services.SpeechToText.Default);

		//-- ViewModels
		builder.Services.AddSingleton<MainPage, MainViewModel>();
		builder.Services.AddSingleton<WelcomePage, ViewModels.Welcome>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}