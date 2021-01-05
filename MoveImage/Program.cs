using System;
using System.Text;
using Form;

namespace Form
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input console color: ");

            string foregrcolor = Console.ReadLine();
            Color ConsColor = new Color(foregrcolor);
            ConsColor.GetConsoleColor();

            int type = 0;
            Console.Write("Choose your image type(1-Rectangle, 2-Triangle): ");
            type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                RectangleConstructor rectangleConstructor = new RectangleConstructor();
                rectangleConstructor.CreateRectangle();
            }
            else if (type == 2)
            {
                TriangleConstructor triangleConstructor = new TriangleConstructor();
                triangleConstructor.CreateTriangle();
            }
            else
            {
                Console.WriteLine("There is no such type.");
            }
        }
    }
}