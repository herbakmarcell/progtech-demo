using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTech2025C
{
    class Shape
    {
        bool isCircle;

        public Shape(bool isCircle)
        {
            this.isCircle = isCircle;
        }

        public void DrawShape()
        {
            // isCircle mezőtől függ a metódus kimenetele
            // OCP-t sért
            if (isCircle)
            {
                DrawCircle();
            }
            else
            {
                DrawRectangle();
            }
        }
        // 1. felelősség
        void DrawCircle()
        {
            Console.WriteLine("O");
        }
        // 2. felelősség - SRP megszegi
        void DrawRectangle()
        {
            Console.WriteLine("Rectangle");
        }
    }

    // Megoldás
    interface IDraw
    {
        void Draw();
    }

    abstract class AbstractShape : IDraw
    {
        public abstract void Draw();
    }

    class Circle : AbstractShape
    {
        // 1. felelősség
        public override void Draw()
        {
            // nincs if - OCP nincs megszegve
            Console.WriteLine("O");
        }
    }

    class Rectangle : AbstractShape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
