namespace Round3_29_01_2025
{
    static internal class _6_TransposeMatrix
    {
        /*
         
         [RowIndex, ColumnIndex] 
         input = [
                    [1,2],          [0,0] , [0.1]
                    [3.4],          [1,0] , [1.1]      
                    [5.6]           [2,0] , [2.1]
                ]

        // swap rows and columns
        output = [
            [1,3,5]
            [2,4,6]
        
        ]
         */
        public static int[,] TransposeMatrix(int[,] twoDArray)
        {
            var numOfRows = twoDArray.GetLength(0);           // Results => num of Cols
            var numOfCols = twoDArray.GetLength(1);           // Results => num of Rows
            int[,] result = new int[numOfCols, numOfRows];    // Rows, Columns

            for (int row = 0; row < numOfRows; row++)
            {
                for (int col = 0; col < numOfCols; col++)
                {
                    result[col, row] = twoDArray[row, col];
                }
            }
            return result;
        }
    }
}
