using Foundation;

namespace RecognizeSpeech;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => RecognizeSpeech.MauiProgram.CreateMauiApp();
}

