using System;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {                                    //Задача 1
            Console.Write("side1 = ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("side2 = ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rect1 = new Rectangle(side1, side2);
            System.Console.WriteLine($"Area = {rect1.Area}\nPerimeter = {rect1.Perimeter}");
            Console.ReadKey();
        }
        class Rectangle
        {
            public double side1 { get; set; }
            public double side2 { get; set; }
            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            public double Area
            {
                get
                {
                    return AreaCalculator();
                }

            }
            public double Perimeter
            {
                get
                {
                    return PerimeterCalculator();
                }
            }
            private double AreaCalculator()
            {
                return this.side1 * this.side2;

            }
            private double PerimeterCalculator()
            {
                return 2 * (this.side1 + this.side2);
            }

        }
    }
}
