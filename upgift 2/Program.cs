using System;
using static System.Net.Mime.MediaTypeNames;
namespace protject_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            {
                Console.WriteLine("Your pc has crashed and requiers a restart");
                Console.WriteLine("we are just colecting some crashreports from your pc");
                Console.WriteLine("please wait while we are resolving your issue");
                Console.ReadKey();
            }
        }

    }
}