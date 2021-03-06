﻿using System;
using System.Threading;
using Guidelines.Core;
using Guidelines.WebUI.Session;

namespace Guidelines.WebUI
{
    public class LocalizationProvider : ILocalizationProvider
    {
		[ThreadStatic]
		private static TimeZoneInfo _timeZone;

        public TimeZoneInfo GetCurrentTimeZone()
        {
            return _timeZone ?? (_timeZone = TimeZoneAspect.GetTimeZone());
        }

        public string GetCurrentLanguageCode()
        {
            return Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        }
    }
}