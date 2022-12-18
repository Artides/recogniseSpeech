﻿using System;
using System.Globalization;

namespace RecognizeSpeech.Services;

public interface ISpeechToText
{
    Task<bool> RequestPermissions();
    Task<string> Listen(CultureInfo culture, IProgress<string>? recognitionResult, CancellationToken cancellationToken);
}

