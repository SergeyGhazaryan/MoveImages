using System;
using System.Collections.Generic;
using System.Text;
using Form;

namespace Form
{
    class MoveImage
    {
        private char[,] matrixFigure;
        private int height;
        private int width;

        public MoveImage(char[,] matrixFigure, int height, int width)
        {
            this.matrixFigure = matrixFigure;
            this.height = height;
            this.width = width;
        }

        public void Moveimage()
        {
            int curs1 = 0, curs2 = 0;
            print(matrixFigure, curs1, curs2);
            while (true)
            {
                print(matrixFigure, curs1, curs2);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (curs1 > 0)
                        {
                            curs1--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (curs1 < Console.WindowWidth - width)
                        {
                            curs1++;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (curs2 < Console.WindowHeight - height)
                        {
                            curs2++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (curs2 > 0)
                        {
                            curs2--;
                        }
                        break;
                }
            }
        }

        public void print(char[,] matrix, int curs1, int curs2)
        {
            Console.Clear();
            for (int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(curs1, curs2);
                curs2++;
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}