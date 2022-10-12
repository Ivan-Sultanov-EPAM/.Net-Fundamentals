using System;

namespace NetCoreConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = args.Length == 0 ? "Command line arguments were not provided" : $"Hello {string.Join(", ", args)}!";

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
