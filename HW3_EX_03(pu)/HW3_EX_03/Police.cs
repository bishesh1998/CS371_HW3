using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_EX_03
{
    class Police : Person
    {
        
        public Police()
        {
        }

        
        public Police(string nomen) : base(nomen)
        {
        }

        //Override speak method 
        public override Person speak()
        {
            Console.WriteLine("I'm Batman!");
            return this;

        }
    }
}
