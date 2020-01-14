using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_EX_03
{
    class Program
    {
        static void Main(string[] args)
        {
            City metropolis = new City();

            //...and add some people to it, including one vampire named David Boreanaz!
            Citizen Fred = new Citizen("Fred Rogers");
            Citizen Pete = new Citizen("Pete Tucker");
            Citizen Anne = new Citizen("Anne Trefry");
            Police Dexter = new Police("Dexter");
            Vampire David = new Vampire("David Boreanaz");

            
            metropolis.addResident(Fred);
            metropolis.addResident(Pete); ;
            metropolis.addResident(Anne);
            metropolis.addResident(Dexter);
            metropolis.addResident(David);


            // Event delegate target. 
            metropolis.checkin((string cmes)=>
            {
                Console.WriteLine("City message: ");
                
                Console.WriteLine(cmes);
                Console.WriteLine();
            });


            string keep_playing = "Y";

            //Now, tour the city and play the game!
            while (keep_playing == "Y")
            {
                metropolis.tourResidents();
                Console.Write("Do you want to tour again (Y/N)? : ");
                keep_playing = Console.ReadLine();
            }

        }


    }
}
