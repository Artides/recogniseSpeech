using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RecognizeSpeech.Services;

namespace RecognizeSpeech.ViewModels;


public partial class Welcome : ObservableObject
{

    private readonly ITextToSpeech textToSpeech;
    [ObservableProperty]
    private List<Locale>? locales;

    [ObservableProperty]
    private Locale? locale;

    public Welcome(ITextToSpeech textToSpeech)
    {
        this.textToSpeech = textToSpeech;
        Locales = new();
        SetLocalesCommand.Execute(null);
    }

    [RelayCommand]
    async Task SetLocales()
    {
        Locales = (await textToSpeech.GetLocalesAsync()).ToList();
        Locale = Locales.FirstOrDefault(x => x.Language.StartsWith("en-GB"));
    }
}

