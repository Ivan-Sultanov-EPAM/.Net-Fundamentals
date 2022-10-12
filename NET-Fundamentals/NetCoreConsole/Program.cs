using ClassLibraryConcat;
using System;

namespace NetCoreConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var message = args.Length == 0 ? "Command line arguments were not provided" : string.Join(", ", args).ToGreeting();

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
