using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    interface IShape
    {
        double CalculateArea();
    }

    class Square : IShape
    {
        double SideLength;

        public Square(double num)
        {
            SideLength = num;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    class Circle : IShape
    {
        double Radius;

        public Circle(double num)
        {
            Radius = num;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Triangle : IShape
    {
        double Bottom,
               Height;

        public Triangle(double num1, double num2)
        {
            Bottom = num1;
            Height = num2;
        }

        public double CalculateArea()
        {
            return Bottom * Height / 2;
        }
    }
}
