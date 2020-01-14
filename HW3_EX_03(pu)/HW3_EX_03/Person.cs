using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_EX_03
{
    class Person
    {
        public string name
        { get;
          set;
        }

        public Person()
        {
            name = "John Doe";
        }

        public Person(string nomen)
        {

            name = nomen;
        }

        //Speak virtual method which returns current instance of class
        public virtual Person speak()
        {
            return this;
        }
    }
}
