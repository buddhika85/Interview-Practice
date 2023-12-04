using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q6TransposeMatrix
    {
        public int[,] TransposeMatrix(int[,] twoDArray)
        {
            var result = new int[twoDArray.GetLength(1), twoDArray.GetLength(0)];
            var rows = twoDArray.GetLength(0);
            var columns = twoDArray.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    var newRow = row;
                    var newCol = col;
                    if (row != col)
                    {
                        newRow = col;
                        newCol = row;
                    }
                    result[newRow, newCol] = twoDArray[row, col];
                }
            }

            return result;
        }
    }
}