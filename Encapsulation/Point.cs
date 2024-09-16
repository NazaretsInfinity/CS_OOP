using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Point
    {
        double x;
        double y;
        public double X { get;set; }
        public double Y { get;set; }   //auto - features

        public double Distance(Point A)
        {
            return Math.Sqrt(Math.Pow(X - A.X,2) + Math.Pow(Y - A.Y, 2));         
        }


        //CONSTRUCTOR
        public Point(double x=0,double y = 0)
        {
            X = x;
            Y = y;
            Console.WriteLine($"constructor:\t {GetHashCode()}");
        }

        ~Point()
        {
            Console.WriteLine($"Destructor:\t {GetHashCode()}");
        }
        // Methods
        public void Print()
        {
            Console.WriteLine($"X = {X} , Y = {Y}");      
        }
    }

}

