using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    class ComparableShapes
    {
        private Square[] squareArray = new Square[2];
        private Pentagon[] pentagonArray = new Pentagon[2];

        public ComparableShapes()
        { 
            squareArray[0] = new Square(20);
            squareArray[1] = new Square(35);

            pentagonArray[0] = new Pentagon(10);
            pentagonArray[1] = new Pentagon(15);
        }
    }
}
