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
        Random r = new Random();

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

        public void FillWithRandomElements(int lowerBound, int upperBound)
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _matrix[i, j] = r.Next(lowerBound, upperBound);
                }
            }
        }

        private void Iinit(int[,] matrix)
        {
            _rows = 0;
            _columns = 0;
            try
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    var temp = matrix[i, 0];
                    _rows++;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

            try
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    var temp = matrix[0, i];
                    _columns++;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

            _matrix = matrix;
        }

        public void PrintMatrix()
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

        public static IntMatrix operator +(IntMatrix left, IntMatrix right)
        {
            if (left.Columns != right.Columns || left.Rows != right.Rows)
                throw new InvalidOperationException("Row and Column number should be equal.");
	
            IntMatrix result = new IntMatrix(right.Rows, right.Columns);

            for (int i = 0; i<left.Rows; i++)
			{
                for (int j = 0; j<left.Columns; j++)
			    {
                    int cellValue = left.GetElement(i, j) + right.GetElement(i, j);
                    result.SetElement(i, j, cellValue);
			    }
			}
            return result;
        }

        public static IntMatrix operator -(IntMatrix left, IntMatrix right)
        {
            if (left.Columns != right.Columns || left.Rows != right.Rows)
                throw new InvalidOperationException("Row and Column number should be equal.");

            IntMatrix result = new IntMatrix(right.Rows, right.Columns);

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < left.Columns; j++)
                {
                    int cellValue = left.GetElement(i, j) - right.GetElement(i, j);
                    result.SetElement(i, j, cellValue);
                }
            }
            return result;
        }

        public static IntMatrix operator *(IntMatrix left, IntMatrix right)
        {
            if(left.Columns != right.Rows)
                throw new InvalidOperationException("Left Column and Right Row number should be equal.");

            IntMatrix result = new IntMatrix(left.Rows, right.Columns);
            

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < right.Columns; j++)
                {
                    int cellValue = 0;
                    for (int k = 0; k < left.Columns; k++)
                    {
                        
                        cellValue += left.GetElement(i, k) * right.GetElement(k, j);
                        result.SetElement(i, j, cellValue);
                    }
                }
            }

            return result;
        }

        //works only if determinant ==1
        public static IntMatrix operator /(IntMatrix left, IntMatrix right)
        {
            if(right.Rows!=right.Columns)
                throw new InvalidOperationException("Right Column and Right Row number should be equal.");
            if (left.Columns != right.Rows)
                throw new InvalidOperationException("Left Column and Right Row number should be equal.");
            
            int determinant = right.GetElement(0, 0) * right.GetElement(1, 1) - right.GetElement(0, 1) * right.GetElement(1, 0);
            if (determinant == 0)
            {
                throw new InvalidOperationException("Right matrix determinant is 0. Operation could not be performed");
            }

            IntMatrix revertedMatrix = FindRevertedMatrix(right, determinant);

            IntMatrix result = left * revertedMatrix;

            return result;

        }

        public static IntMatrix FindRevertedMatrix(IntMatrix matrix, int determinant)
        {
            if (matrix.Rows != 2 || matrix.Columns != 2)
                throw new InvalidOperationException("Below case is valid only for 2X2 right matrix.");

            IntMatrix result = new IntMatrix(2, 2);

            int revertedDeterminant = 1 / determinant;
            int topLeftCellValue = matrix.GetElement(0, 0);
            int topRightCellValue = matrix.GetElement(0, 1);
            int bottomLeftCellValue = matrix.GetElement(1, 0);
            int bottomRightCellValue = matrix.GetElement(1, 1);

            result.SetElement(0, 0, bottomRightCellValue * revertedDeterminant);
            result.SetElement(1, 1, topLeftCellValue * revertedDeterminant);
            result.SetElement(0, 1, topRightCellValue * (-1) * revertedDeterminant);
            result.SetElement(1, 0, bottomLeftCellValue * (-1) * revertedDeterminant);

            return result;

        }

        public static bool operator ==(IntMatrix left, IntMatrix right)
        {
            if (left.Columns != right.Columns || left.Rows != right.Rows)
                throw new InvalidOperationException("Row and Column number should be equal.");

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < left.Columns; j++)
                {
                    if (left.GetElement(i, j) != right.GetElement(i, j)){

                        return false;
                    }
                }
            }
            return true;
        }

        public static bool operator !=(IntMatrix left, IntMatrix right)
        {
            if (left.Columns != right.Columns || left.Rows != right.Rows)
                throw new InvalidOperationException("Row and Column number should be equal.");

            for (int i = 0; i < left.Rows; i++)
            {
                for (int j = 0; j < left.Columns; j++)
                {
                    if (left.GetElement(i, j) != right.GetElement(i, j)){

                        return true;
                    }
                }
            }
            return false;
        }

        public static IntMatrix operator *(IntMatrix matrix, int number)
        {
            IntMatrix result = new IntMatrix(matrix.Rows, matrix.Columns);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    int cellValue = matrix.GetElement(i, j) * number;
                    result.SetElement(i, j, cellValue);
                }
            }
            return result;
        }

        //return 0 as cellValue is double
        public static IntMatrix operator /(IntMatrix matrix, int number)
        {
            IntMatrix result = new IntMatrix(matrix.Rows, matrix.Columns);
            int divider = 1 / number;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    int cellValue = matrix.GetElement(i, j) * divider;
                    result.SetElement(i, j, cellValue);
                }
            }
            return result;
        }

        public static int[] operator *(IntMatrix matrix, int[] array)
        {
            int[] result = new int[matrix.Rows];
            if (matrix.Columns != array.Length)
                throw new InvalidOperationException("Matrix columns number and array length should equal");

            for (int i = 0; i < matrix.Rows; i++)
            {
                int cellValue = 0;

                for (int j = 0; j < matrix.Columns ; j++)
                {
                     cellValue += matrix.GetElement(i, j) * array[j];
                     
                }
                result.SetValue(cellValue, i);
            }

            return result;
        }





    }
}
