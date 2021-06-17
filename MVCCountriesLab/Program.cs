using System;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello, welcome to the country app.");
            CountryController cc = new CountryController();
            cc.WelcomeAction();
        }
    }
}
