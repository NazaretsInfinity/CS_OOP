﻿#define checking
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if checking1
            Fraction A = new Fraction();
            A.Print();
            Console.WriteLine(A);

            Fraction B = new Fraction(5);
            B.Print();
            Console.WriteLine(B);

            Fraction C = new Fraction(1, 2);
            C.Print();
            Console.WriteLine(C);

            Fraction D = new Fraction(2, 3, 4);
            D.Print();
            Console.WriteLine(D);

#endif

            Fraction A = new Fraction(3);
            Fraction B = new Fraction(12,4);
            Console.WriteLine(A);
            Console.WriteLine(B);
           

           Fraction C = A*B;          
           Fraction D = A+B;           
           Fraction E = A-B;
           Fraction F = A/B;

            Console.WriteLine(C);
            Console.WriteLine(D);
            Console.WriteLine(E);
            Console.WriteLine(F);    
            Console.WriteLine(A==B);
           // Console.WriteLine(A!=B);
         
        }
    }
}
