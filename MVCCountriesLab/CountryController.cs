﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MVCCountriesLab
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>();

        public CountryController()
        {
            string filePath = "CountriesDB.txt";
            StreamReader reader = new StreamReader(filePath);
            string output = reader.ReadToEnd();
          
            string[] lines = output.Split('\n');
           
            foreach (string line in lines)
            {
                Country con = ConvertToCountry(line);
                if (con != null)
                {
                    CountryDb.Add(con);
                }
            }
        }

        public static Country ConvertToCountry(string line)
        {
            string[] properties = line.Split(';');
            Country c = new Country();

            if (properties.Length == 3)
            {
                c.Name = properties[0];
                c.Continent = properties[1];
                c.Colors = properties[2].Split(new char[] { ',' }).ToList();
                return c;
            }
            else
            {
                return null;
            }
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();

        }

        public void WelcomeAction()
        {

            Console.WriteLine("Hello, welcome to the country app.");
            Console.WriteLine("Please select a country from the following list:");
            CountryListView clv = new CountryListView(CountryDb);
            clv.Display();

            int input;
            while (Int32.TryParse(Console.ReadLine(), out input) != true)
            {
                Console.WriteLine("Invalid input please try again.");
            }


            Country output = CountryDb[input];
            CountryAction(output);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWould you like to learn about another country?");
            if(Console.ReadLine().ToLower() == "y")
            {
                WelcomeAction();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }

        }
    }
}
