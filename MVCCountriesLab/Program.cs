using System;

namespace MVCCountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();
            cc.WelcomeAction();
        }
    }
}
