#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        //add two private fields, called x and y of type int
        private int x, y;

        //default constructor
        public Point()
        {
            Console.WriteLine("Default constructor called");
        }
        public Point(int x, int y)
        {
            this.x = -1;
            this.y = -1;
            Console.WriteLine($"x:{x}, y:{y}");
        }

        //public instance method..accepts a sign Point argument called other and returns a double
        public double DistanceTo(Point other)
        {
            //declare a local int variable called xDiff
            //initialize xDiff w/difference between this.x and this.y
            int xDiff = this.x - other.x;
            //declare another local int varaible called yDiff
            int yDiff = this.y - other.y;
            //declare a variable called distance of type double and use it to hold the result of the calculation
            double distance = Math.Sqrt((xDiff*xDiff) + (yDiff*yDiff));
            //return value in distance variable
            return distance;
        }
    }
}
