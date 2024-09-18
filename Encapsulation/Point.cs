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
        public double X {
            get { return x; }
            set { x = value; } 
        }
        public double Y {

            get
            { return y; }
            set { y = value;}
        }   //auto - features

        public double Distance(Point A)
        {
            return Math.Sqrt(Math.Pow(x- A.X,2) + Math.Pow(Y - A.Y, 2));         
        }


        //CONSTRUCTOR
        public Point(double x=0,double y = 0)
        {
            X = x;
            Y = y;
            Console.WriteLine($"constructor:\t {GetHashCode()}");
        }

        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
            Console.WriteLine($"copy constructor:\t {GetHashCode()}");
        }
        ~Point()
        {
            Console.WriteLine($"Destructor:\t {GetHashCode()}");
        }

        //OPERATORS 

        public static Point operator+(Point a,Point b)
        {
            return new Point(a.X+b.X , a.Y+b.Y);
        }
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static bool operator ==(Point point, Point other)
        {
            return point.X == other.X && point.Y == other.Y;
        }
        public static bool operator!=(Point point, Point other)
        {
            return !(point==other);
        }
        public static Point operator++(Point obj)
        {
            obj.X++;
            obj.Y++;
            return obj;
        }
    
        // Methods
        public void Print()
        {
            Console.WriteLine($"X = {X} , Y = {Y}");      
        }
    }

}

