using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    class Triangle
    {
        private int sides;

        public Triangle(int sides)
        {
            this.sides = sides;
        }

        public char[,] Tri()
        {
            char[,] arr = new char[sides, sides];
            for (int i = 0; i < sides; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    arr[i, j] = '*';
                }
            }
            return arr;
        }
    }
}