using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW2_Ex1
{
    //Shape Container Class
    //Inheritance of IEnumerable
    class Shapes : IEnumerable
    {
        private Circle[] cirlceArray = new Circle[3];
        private Square[] squareArray = new Square[2];
        private Triangle[] triangleArray = new Triangle[4];

        //IEnumerator interface to return square
        public IEnumerator GetEnumerator()
        {
            foreach (Square S in squareArray)
            {
                yield return S;
            }
        }
 
        //Default Constructor
        public Shapes()
        {

            cirlceArray[0] = new Circle(10,"Red");
            cirlceArray[1] = new Circle(7, "Blue");
            cirlceArray[2] = new Circle(21, "Yellow");

            squareArray[0] = new Square(20);
            squareArray[1] = new Square(40);

            triangleArray[0] = new Triangle(5,"Green");
            triangleArray[1] = new Triangle(6, "Purple");
            triangleArray[2] = new Triangle(7, "Orange");
            triangleArray[3] = new Triangle(8, "Brown");

        }
    }
}
