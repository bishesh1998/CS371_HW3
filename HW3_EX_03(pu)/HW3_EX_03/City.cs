using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_EX_03
{

    class City
    {

        private List<Person> residents = new List<Person>();

        //Adds person to residents
        public void addResident(Person p)
        {
            residents.Add(p);
        }
        
        public delegate void handler(string message);

        //Member variable of the delegate
        public handler handlerl;

        //caller checkin
        public void checkin(handler mc)
        {
            handlerl += mc;
        }

        

        public void tourResidents()
        {
            Console.WriteLine("Welcome to our city! Let our citizens introduce themselves!");
            for (int i = 0; i < residents.Count; i++)
            {

                if (residents[i] is Vampire) // Change this so that the if clause handles vampires.
                {
                    if (handlerl !=null)
                    {
                        //event
                        handlerl("Storm approaching."); 
                    }

                    Console.Write("Something feels evil about the approaching citizen. Do you still approach (Y/N)? : ");
                    string yn;
                    yn = Console.ReadLine();
                    if (yn != "Y") 
                    {
                        Console.WriteLine("Good call! That guy gave me the heebie jeebies.");
                    }
                    else
                    {
                        //Capture a pointer to the former tourist's self, and add it as a new vampire to the city
                        residents.Add(residents[i].speak());
                        break; // Don't want to continue the tour!
                    }
                }
                else
                {
                    if (handlerl != null)
                    {

                        handlerl("Situation is under control"); 
                    }

                    residents[i].speak(); 
                }
            }
        }
    }

}
