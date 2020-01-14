//////////////////////////////////////////////////////////////////////////////////
// HW 3 : EX 03
// CS371 - Whitworth University
// Originally outlined by: Bishesh Tuladhar
// Worked With : Sabin Sapkota & Novel Poudel
/////////////////////////////////////////////////////////////////////////////

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

            metropolis.RegisterWithCity(OnCityEvent); //Running the event of the city

            string keep_playing = "Y";

            //Now, tour the city and play the game!
            while (keep_playing == "Y")
            {
                metropolis.tourResidents();
                Console.Write("Do you want to tour again (Y/N)? : ");
                keep_playing = Console.ReadLine();
            }

        }

        // This is the target for for the city event delegates
        public static void OnCityEvent(string msg)
        {
            Console.WriteLine("\n***** Message From City Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***********************************\n");
        }
    }
}
