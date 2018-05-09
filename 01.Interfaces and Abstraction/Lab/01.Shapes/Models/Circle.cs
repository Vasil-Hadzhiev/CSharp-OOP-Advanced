namespace _01.Shapes.Models
{
    using System;
    using Interfaces;

    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }

        public void Draw()
        {
            double rIn = this.radius - 0.4;
            double rOut = this.radius + 0.4;

            for (double i = this.radius; i >= -this.radius; i--)
            {
                for (double j = -this.radius; j < rOut; j += 0.5)
                {
                    double value = i * i + j * j;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}