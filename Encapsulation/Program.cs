using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static double Distance(Point A, Point B)
        {
          // return A.Distance(B);
           return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        static void Main(string[] args)
        {
            Point A = new Point(); // 'new' call Constructor of class;
            A.Print();


            Point B = new Point(11,12); 
            //ref       //object
            B.X = 3;
            B.Y = 4;
            B.Print();
            Console.WriteLine(B.Distance(A));
            Console.WriteLine(A.Distance(B));
            Console.WriteLine(Distance(A,B));
            Console.WriteLine(Distance(B,A));

        }
    }
}
