using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW2_Ex1
{
    //ComparableShapes Container Class
    //Inheritance of IEnumerable
    class ComparableShapes : IEnumerable
    {
        private Square[] squareArray = new Square[2];
        private Pentagon[] pentagonArray = new Pentagon[2];

        public ComparableShapes()
        {
            squareArray[0] = new Square(20);
            squareArray[1] = new Square(35);

            pentagonArray[0] = new Pentagon(10);
            pentagonArray[1] = new Pentagon(50);
        }

        //IEnumerator Interface
        public IEnumerator GetEnumerator()
        {
            int c = 0;
            
            //foreach loop to compare all the square in to to the pentagon
            foreach (Square S in squareArray)
            {
                if (squareArray[c].getparameter() > pentagonArray[c].getparameter())
                {
                    Console.WriteLine("Sqaure {0} is greater than Pentagon {0}", c);
                }
                else if (squareArray[c].getparameter() < pentagonArray[c].getparameter())
                {
                    Console.WriteLine("Pentagon {0} is greater than Sqaure {0}", c);
                }
                else
                {
                    Console.WriteLine("Sqaure {0} is equal to Pentagon {0}", c);
                }
                c++;
                yield return S;
            }

        }
    }
}
