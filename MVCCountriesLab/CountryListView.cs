using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountriesLab
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }
        

        public void Display()
        {


            for (int i =0; i < Countries.Count; i++)
            {
                Country c = Countries[i];
                Console.WriteLine($"{i}: {c.Name}");
            }
            

        }

    }
}
