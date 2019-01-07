using MatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkWithMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            IntMatrix matrix = new IntMatrix(5,5);
            FillWithRandomElements(matrix);


            Console.ReadLine();
        }

        static void FillWithRandomElements(IntMatrix matrix)
        {
            Random r = new Random();
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    matrix.SetElement(i, j, r.Next(0, 11));
                }
            }
        }
    }
}
