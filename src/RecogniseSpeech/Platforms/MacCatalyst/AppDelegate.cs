using Foundation;

namespace RecogniseSpeech;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiSpeech.MauiProgram.CreateMauiApp();
}

