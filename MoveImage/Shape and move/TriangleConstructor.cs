using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class TriangleConstructor
    {
        public void CreateTriangle()
        {
            int sides = 0;
            Console.WriteLine("Enter the side of the triangle.");
            Console.WriteLine();
            Console.Write("Sides: ");
            sides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Triangle triangle = new Triangle(sides);
            char[,] matrixTri = triangle.Tri();
            MoveImage MoveImg = new MoveImage(matrixTri, sides, sides);
            MoveImg.Moveimage();
        }
    }
}
