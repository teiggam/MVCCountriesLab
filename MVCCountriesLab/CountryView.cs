using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MVCCountriesLab
{
    public class CountryView
    {
        public Country DisplayCountry { get; set; }
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public void Display()
        {
            var colors = string.Join(",", DisplayCountry.Colors);

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[0], true);
            Console.WriteLine($"Name: {DisplayCountry.Name}");
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[1], true);
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            try
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[2], true);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[0], true);
            }
            Console.WriteLine($"Colors: {colors}");

        }
    }
}
