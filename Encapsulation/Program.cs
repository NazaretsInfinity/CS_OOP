#define checking
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
#if checking1 //construct check
            Point A = new Point(); // 'new' call Constructor of class;
            A.Print();


            Point B = new Point(7, 8);
            //ref       //object

            B.Print();
            //Console.WriteLine(B.Distance(A));

            Point C = B; // copies address of B to C , not object
            Point D = new Point(B); // copy constructor , but need a realization for it first


#endif
            Point A = new Point(2, 3);
            Point B = new Point(7, 8);
            Point C = new Point(A+B);
            Point D = new Point(A-B);
            A.Print();
            B.Print();
            C.Print();
            D.Print();
            Point n = new Point(10, 10);
            for (Point i = new Point(); i != n;i++)
            {
                i.Print();
            }

        }
    }
}
