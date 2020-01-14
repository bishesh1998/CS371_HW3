using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Ex3
{
	//Police Class inheritance from person 
    class Police : Person
    {
		//Default class
        public Police(){ }

		//Constructor
        public Police(string nomen) : base(nomen) { }

		//Speak method
		//Returns current object
		public override Person speak()
		{
			Console.WriteLine("I'm Batman!");
			return this;

		}
	}
}
