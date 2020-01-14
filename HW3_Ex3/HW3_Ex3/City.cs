using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW3_Ex3
{
    class City
    {
        private List<Person> residents = new List<Person>();

        //Method to add person to the city list
        public void addResident(Person p)
        {
            residents.Add(p);
        }

        //Defining a delegate type.
        public delegate void CityHandlers(string msgForCaller);

        //Member variable of the delegate
        public CityHandlers listofHandlers;

        //registration function for the caller
        public void RegisterWithCity(CityHandlers methodToCall)
        {
            listofHandlers += methodToCall;
        }

        //More on this hopefully later in the term. For now, I think what it's doing is intuitive,
        //so let's just focus on polymorphism, shall we.
        //Your mission: change this so that it gives the tourist a chance to escape vampires.
        public void tourResidents()
        {
            Console.WriteLine("Welcome to our city! Let our citizens introduce themselves!");
            for (int i = 0; i < residents.Count; i++)
            {
                if (residents[i] is Vampire) // Change this so that the if clause handles vampires.
                {
                    if (listofHandlers != null)
                    {
                        listofHandlers("The Wind is blowing strong, birds are running away, something is NOT OK."); //event of the city
                    }

                    Console.Write("Something feels evil about the approaching citizen. Do you still approach (Y/N)? : ");
                    string yn;
                    yn = Console.ReadLine();
                    if (yn != "Y") // The else clause allows the tourist to try to escape the vampire.
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
                    if (listofHandlers != null)
                    {
                        listofHandlers("City is safe, birds' are chirping, Everything is OK."); //event of the city
                    }
                    residents[i].speak(); //Invoking the speak method of the person
                }
            }
        }
    }
}
