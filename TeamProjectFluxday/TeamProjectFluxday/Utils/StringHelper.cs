using System;

namespace TeamProjectFluxday.Utils
{
    public static class StringHelper
    {
        public static string GenerateDateTimeString()
        {
            return DateTime.Now.ToString("yyyyMMdd_HHmmss");
        }

        public static string PrependDateTimeString(string text)
        {
            return GenerateDateTimeString() + text;
        }

        public static string AppendDateTimeString(string text)
        {
            return text + GenerateDateTimeString();
        }
    }
}
