//////////////////////////////////////////////////////////////////////////////////
// HW 3 : EX 02
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

            Shapes Toy = new Shapes(); //Shapes Container
            int c = 0;

            Console.WriteLine("Counting Square in the toys");
            foreach (Shape T in Toy) //foreach loop to count Squares
            {
                c++;
                Console.WriteLine("Square Counter : {0}", c);
            }
            Console.WriteLine();

            ComparableShapes Blocks = new ComparableShapes(); //ComparableShapes container

            Console.WriteLine("Comparing the blocks.");
            foreach (Square S in Blocks) //foreach loop to compare Sqaure and Pentagon
            {
                //Console.WriteLine("testing");
            }

        }
    }
}
