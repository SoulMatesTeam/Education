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
            matrix.FillWithRandomElements(10, 51);
            matrix.PrintMatrix();

            Console.ReadLine();
        }
    }
}
