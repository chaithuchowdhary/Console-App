using System;
#Modified
namespace ConsoleApp1
{
    class Circle : Shape
    { 
        public int Radius { get; set; }

        public Circle(int Radius)
        {
            this.Radius = Radius;
        }

        public override void area()
        {
            Console.WriteLine($"Area of Circle { Math.PI* Radius * Radius}");
        }
    }
}
