using System;

namespace ClassLibraryConcat
{
    public static class TextExtensions
    {
        public static string ToGreeting(this string name)
        {
            return $"{DateTime.Now:HH:mm} Hello, {name}!";
        }
    }
}
