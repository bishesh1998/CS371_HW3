using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's make a city...
            City metropolis = new City();
            Citizen Fred = new Citizen("Fred Rogers");
            Citizen Pete = new Citizen("Pete Tucker");
            Citizen Anne = new Citizen("Anne Trefry");
            Police Dexter = new Police("Dexter");
            Vampire David = new Vampire("David Boreanaz");

            //...and add some people to it, including one vampire named David Boreanaz!
            metropolis.addResident(Fred);
            metropolis.addResident(Pete); ;
            metropolis.addResident(Anne);
            metropolis.addResident(Dexter);
            metropolis.addResident(David);

            string keep_playing = "Y";

            while (keep_playing == "Y")
            {
                metropolis.tourResidents();
                Console.Write("Do you want to tour again (Y/N)? : ");
                keep_playing = Console.ReadLine();
            }

            //metropolis.RegisterWithCity(new City.CityHandlers(OnCityEvent2));

        }

        public static void OnCityEvent(string msg)
        {
            Console.WriteLine("\n***** Message From City Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }

        public static void OnCityEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
