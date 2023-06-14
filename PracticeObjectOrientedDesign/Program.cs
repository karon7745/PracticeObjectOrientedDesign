using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape square = new Square(10);
            IShape triangle = new Triangle(3, 5);

            Console.WriteLine("円の面積: " + circle.CalculateArea());
            Console.WriteLine("正方形の面積: " + square.CalculateArea());
            Console.WriteLine("三方形の面積: " + triangle.CalculateArea());
        }
    }
}
