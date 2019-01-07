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
    }
}
