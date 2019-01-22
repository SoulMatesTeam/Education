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
            Console.WriteLine("Matrix1");
            IntMatrix matrix1 = new IntMatrix(2,2);
            matrix1.FillWithRandomElements(1, 5);
            matrix1.PrintMatrix();

            Console.WriteLine("Matrix2");
            IntMatrix matrix2 = new IntMatrix(2, 2);
            matrix2.FillWithRandomElements(1, 5);
            matrix2.PrintMatrix();

            Console.WriteLine("Matrix1 + Matrix2");
            IntMatrix matrix3 = matrix1 + matrix2;
            matrix3.PrintMatrix();

            Console.WriteLine("Matrix1 - Matrix2");
            IntMatrix matrix4 = matrix1 - matrix2;
            matrix4.PrintMatrix();

            Console.WriteLine("Matrix1 * Matrix2");
            IntMatrix matrix5 = matrix1 * matrix2;
            matrix5.PrintMatrix();

            correct if determinant = 1;
            Console.WriteLine("Matrix1 / Matrix2");
            IntMatrix matrix6 = matrix1 / matrix2;
            matrix6.PrintMatrix();

            Console.WriteLine("Matrix1==Matrix2");
            bool matricesAreEqual = matrix1 == matrix2;
            Console.WriteLine(matricesAreEqual);

            Console.WriteLine("Matrix1!=Matrix2");
            bool matricesAreNotEqual = matrix1 != matrix2;
            Console.WriteLine(matricesAreNotEqual);

            Console.WriteLine("Matrix1 * 2");
            IntMatrix matrix7 = matrix1 * 2;
            matrix7.PrintMatrix();

            Console.WriteLine("Matrix2 / 2");
            IntMatrix matrix8 = matrix2 / 2;
            matrix8.PrintMatrix();

            Console.WriteLine("Matrix1 * array");
            int[] array = new int[2] { 3, 4 };
            int[] resultArray = matrix1 * array;

            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");

            }


            Console.ReadLine();
        }
    }
}
