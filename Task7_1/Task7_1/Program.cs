using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape Fectangle, Triangle, Circle, Square, IsoscelesTriangle;

            Fectangle = new Fectangle(4, 5);
            Triangle = new Triangle(8, 9);
            Circle = new Circle(5);
            Square = new Square(7);
            IsoscelesTriangle = new IsoscelesTriangle(7, 5);

            string nameOfFectangle = Fectangle.GetName();
            double areaOfFectangle = Fectangle.GetArea();

            string nameOfSquare = Square.GetName();
            double areaOfSquere = Square.GetArea();

            string nameOfTriangle = Triangle.GetName();
            double areaOfTriangle = Triangle.GetArea();

            string nameOfCircle = Circle.GetName();
            double areaOfCircle = Circle.GetArea();

            string nameOfIsoscelesTriangle = IsoscelesTriangle.GetName();
            double areaOfIsoscelesTriangle = IsoscelesTriangle.GetArea();
        }
    }
}
