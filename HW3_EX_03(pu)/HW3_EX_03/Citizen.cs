using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_EX_03
{
    class Citizen : Person
    {
        public Citizen() {

        }
        
        public Citizen(string nomen) : base(nomen)
        {
        }

        //Override virtual method speak
        public override Person speak()
        {
            Console.WriteLine("What a beautiful day! Surely nothing could go wrong.");

            return this;
        }

    }

}





