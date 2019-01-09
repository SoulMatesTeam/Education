using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixLibrary
{
    public class IntMatrix
    {
        private int _rows;
        private int _columns;

        private int[,] _matrix;

        public int Rows => _rows;
        public int Columns => _columns;

        public IntMatrix(int rows, int columns)
        {
            _matrix = new int[rows, columns];
            _rows = rows;
            _columns = columns;
        }

        public void SetElement(int rowNumber, int columnNumber, int val)
        {
            _matrix[rowNumber, columnNumber] = val;
        }

        public int GetElement(int rowNumber, int columnNumber)
        {
            return _matrix[rowNumber, columnNumber];
        }

        public void FillWithRandomElements(IntMatrix matrix, int lowerBound, int upperBound)
        {
            Random r = new Random();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    matrix.SetElement(i, j, r.Next(lowerBound, upperBound));
                   // _matrix[i, j] = r.Next(lowerBound, upperBound);
                }
            }
        }

        public void PrintMatrix(IntMatrix matrix)
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write(_matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
