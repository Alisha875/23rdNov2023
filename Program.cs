using ShapeAreaLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of shape (1.Rectangle, 2.Square, 3.Circle, 4.Triangle): ");
            string shapeType = Console.ReadLine();
            Shape area = null;

            switch (shapeType)
            {
                case "Rectangle":
                    Console.WriteLine("Enter length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    area = new Rectangle(length, width);
                    break;
                case "Square":
                    Console.WriteLine("Enter side: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    area = new Square(side);
                    break;
                case "Circle":
                    Console.WriteLine("Enter radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    area = new Circle(radius);
                    break;
                case "Triangle":
                    Console.WriteLine("Enter base length: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    area = new Traingle(baseLength, height);
                    break;
                default:
                    Console.WriteLine("Invalid shape type");
                    return;
            }

            Console.WriteLine($"The area of the {shapeType} is {area.Area()}");
            Console.ReadKey();
        }
    }
}
