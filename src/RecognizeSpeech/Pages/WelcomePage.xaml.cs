namespace RecognizeSpeech.Pages;

public partial class WelcomePage : ContentPage
{
	public WelcomePage(ViewModels.Welcome welcome)
	{
		InitializeComponent();
		BindingContext = welcome;
	}
}
