using System.Globalization;
using RecognizeSpeech.Platforms;

namespace RecognizeSpeech.Services;

public static class SpeechToText
{
	static ISpeechToText? defaultImplementation;

	public static Task<bool> RequestPermissions()
	{
		return Default.RequestPermissions();
	}
	
	public static Task<string> Listen(CultureInfo culture, IProgress<string>? recognitionResult, CancellationToken cancellationToken)
	{
		return Default.Listen(culture, recognitionResult, cancellationToken);
	}

	public static ISpeechToText Default =>
		defaultImplementation ??= new SpeechToTextImplementation();

	internal static void SetDefault(ISpeechToText? implementation) =>
		defaultImplementation = implementation;
}

