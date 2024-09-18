using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
       public int Integer {  get; set; }
       public int Numerator{  get; set; }

        int denominator;

        public int Denominator
        {
            get => denominator;
            set=> denominator = value==0? 1 : value;
        }
        public Fraction(int integer)
        {
            this.Integer = integer;
            this.Denominator = 1;
            Console.WriteLine($"OneArgumentConstructor: {GetHashCode()}");
        }

        public Fraction()
        {
            Console.WriteLine($"DefaultConstructor: {GetHashCode()}");
        }

        public Fraction(int numerator,int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Console.WriteLine($"NoIntConstructor: {GetHashCode()}");
        }

        public Fraction(int integer, int numerator, int denominator)
        {
            Integer = integer;
            Numerator=numerator;
            Denominator = denominator;
            Console.WriteLine($"Constructor: {GetHashCode()}"); 
        }


        public Fraction(Fraction other)
        {
            this.Integer=other.Integer;
            this.Numerator=other.Numerator; 
            this.Denominator=other.Denominator;
            Console.WriteLine($"CopyConstructor: {GetHashCode()}"); 
        }
        ~Fraction()
        {
            Console.WriteLine($"Destructor: {GetHashCode()}");
        }


        //OPERATORS

        public static Fraction operator*(Fraction first, Fraction second)
        {
           Fraction one = first.Improper();
           Fraction two = second.Improper();
           Fraction result  = new Fraction(one.Numerator*two.Numerator,one.Denominator*two.Denominator);
           return result;
        }

        public static Fraction operator+(Fraction first, Fraction second)
        {
            return new Fraction(first.Integer + second.Integer,
                first.Numerator*second.Denominator+first.Denominator*second.Numerator,
                first.Denominator*second.Denominator
                );
        }

        public static Fraction operator-(Fraction one, Fraction two)
        {
            Fraction first = one.Improper();
            Fraction second = two.Improper();
           return new Fraction(first.Numerator*second.Denominator - second.Numerator*first.Denominator, first.Denominator*second.Denominator);
        }



        public static Fraction operator/(Fraction first, Fraction second)
        {
            return new Fraction(first * new Fraction(second.Denominator, second.Numerator +
                (second.Integer !=0 ? second.Integer*second.Denominator : 0)));
        }
        //COMPRASION 


        public static bool operator ==(Fraction first, Fraction second)
        {
            Fraction one = first.Improper();
            Fraction two = second.Improper();
            return one.Integer == two.Integer && one.Numerator*two.Denominator == one.Denominator*two.Numerator;       
        }

        public static bool operator !=(Fraction one, Fraction two)
        {
            return !(one == two);
        }


        //METHODS
        Fraction Improper()
        {
            Fraction copy = new Fraction(this);
            copy.Numerator += this.Integer * this.Denominator;
            copy.Integer = 0;
            return copy;
        }

        Fraction Proper()
        {
            Fraction copy = new Fraction(this);
            copy.Integer += Numerator / Denominator;
            copy.Numerator %= Denominator;
            return copy;
        }

        public  void Print()
        {

            if (Integer != 0) Console.Write(Integer);
            if (Numerator != 0)
            {
                if (Integer != 0) Console.Write("(");
                Console.Write($"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");
            }
            else if (Integer == 0) Console.Write(0);
            Console.WriteLine();
        }

        public override string ToString()
        {
            string result = " ";

            if (Integer != 0) result+= Integer;
            if (Numerator != 0)
            {
                if (Integer != 0) result += "(";
                result += $"{Numerator}/{Denominator}";
                if (Integer != 0) result += ")";
            }
            else if (Integer == 0) result += 0;
            return result;
        }
    }
}
