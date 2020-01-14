using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Ex3
{
	//Citizen class inheritance from person
    class Citizen : Person
    {
		//Default Constructor
        public Citizen() { }
		//Constructor
        public Citizen(string nomen) : base(nomen) { }

		//Speak method
		//Returns current object
		public override Person speak()
		{
			Console.WriteLine("What a beautiful day! Surely nothing could go wrong.");
			return this;
		}
	}
}
