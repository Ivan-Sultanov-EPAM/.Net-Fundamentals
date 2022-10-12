using ClassLibraryConcat;
using System;

namespace NetCoreConsole
{
    public static class Hello
    {
        public static void DisplayGreetings(string[] names)
        {
            Console.WriteLine(names.Length == 0
                ? "Command line arguments were not provided"
                : string.Join(", ", names).ToGreeting());

            Console.ReadLine();
        }
    }
}
