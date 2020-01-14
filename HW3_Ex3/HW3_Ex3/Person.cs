using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Ex3
{
	//Person Class
	class Person
	{
		public string name { get; set; }

		//Default Constuctor
		public Person()
		{
			name = "John Doe";
		}

		//Constructor
		public Person(string nomen)
		{
			name = nomen;
		}

		//Virtual method to return the current class
		public virtual Person speak()
		{
			Console.WriteLine("Hello, I am a Person.");
			return this;
		}

    }
}
