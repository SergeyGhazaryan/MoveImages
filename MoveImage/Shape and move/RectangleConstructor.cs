using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class RectangleConstructor
    {
        public void CreateRectangle()
        {
            int height = 0, width = 0;
            Console.WriteLine("Enter height and width of the rectangle.");
            Console.WriteLine();
            Console.Write("Height: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Rectangle rectangle = new Rectangle(height, width);
            char[,] matrixRect = rectangle.Rect();
            MoveImage MoveImage = new MoveImage(matrixRect, height, width);
            MoveImage.Moveimage();
        }
    }
}