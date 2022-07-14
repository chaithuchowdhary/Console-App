using System;

namespace ConsoleApp1
{
    class Cylinder : Circle
    {
        public int Height { get; set; }
        public Cylinder(int Height, int radius):base(radius)
        {
            this.Height = Height;
            this.Radius = radius;
        }

        public override void area()
        {
            Console.WriteLine($"Area of Cylider { 2 * Math.PI * Radius * Radius + 2 * Math.PI * Radius * Height}");
        }
    }
}
