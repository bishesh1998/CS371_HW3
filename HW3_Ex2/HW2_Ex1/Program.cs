//////////////////////////////////////////////////////////////////////////////////
// HW 3 : EX 01
// CS371 - Whitworth University
// Originally outlined by: Bishesh Tuladhar
// Worked With : Sabin Sapkota & Novel Poudel
/////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string rad, len; //user input 
            double r, l; //conversion of user input
            Console.Write("Enter the radiusa of the cricle : ");
            rad = Console.ReadLine();
            r = Convert.ToDouble(rad);
            Console.Write("Enter the length of the sqaure :");
            len = Console.ReadLine();
            l = Convert.ToDouble(len);

            Circle C1 = new Circle(r, "Green"); //generating new Circle
            Square S1 = new Square(l); //generating new Square
            
            Console.Write("Parameter of the Cirlce : ");
            Console.WriteLine(C1.getparameter()); //calculating the parameter of Cirlce
            Console.Write("Parameter of the Square : ");
            Console.WriteLine(S1.getparameter()); //calculating the parameter of Square

            //Comparing the two parameters
            if (C1.CompareTo(S1) > 0) //condition for circle being greater
            {
                Console.WriteLine("Circle has greater parameter than Square.");
            }
            else if (C1.CompareTo(S1) < 0) //condition for square being greater
            {
                Console.WriteLine("Square has greater parameter than Circle");
            }
            else //condition for both being equal
            {
                Console.WriteLine("Both Shapes has same parameters.");
            }
            */

            Shapes Toy = new Shapes();

            foreach (Triangle T in Toy)
            {
                Console.WriteLine("testing...");
            }


        }
    }
}
