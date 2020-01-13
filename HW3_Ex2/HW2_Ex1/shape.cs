using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Ex1
{
    //Parent class
    class Shape : IComparable
    {
        private string color;
        protected double parameter;

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Shape otherShape = obj as Shape;

            if (otherShape != null)
            {
                return this.parameter_value.CompareTo(otherShape.parameter_value);
            }
            else
            {
                throw new ArgumentException("Object is not a Shape.");
            }
        }

        //Default Constructor
       public Shape()  
        {
            color = "White";
        }

        //Constructor
        public Shape(string c)
        {
            color = c;
        }

        //Property of Color
        public string color_value
        {
            get { return color; }
            set { color = value; }
        }

        public double parameter_value
        {
            get { return parameter; }
            set { parameter = value; }
        }

        //Virtual Method to get the parameter of the shape
        public virtual double getparameter()
        {
            Console.WriteLine("Generic Shapes don't have a valid parameter!");
            return 0.0;
        } 

    }
}
