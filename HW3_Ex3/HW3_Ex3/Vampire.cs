using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Ex3
{
    //Vampire class inheritance from person class
    class Vampire : Person
    {
        //default Constrcutor
        public Vampire() { }
        //Constructor
        public Vampire(string nomen) : base(nomen) { }

        //Speak method
        //Returns new object vampire
        //Adds the new name of the person as well
        public override Person speak()
        {
            Console.WriteLine("Ssssssss! <Bite!> <Bite!> <Bite!>");
            Console.WriteLine("You've been bitten by a vampire and now are a cursed undead.");
            Console.Write("What was your name in life, former mortal? : ");
            string name;
            name = Console.ReadLine();

            Vampire spawn = new Vampire(name);
            return spawn;
        }
    }
}
