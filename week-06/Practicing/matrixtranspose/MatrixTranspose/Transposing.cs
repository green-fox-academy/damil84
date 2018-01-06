using System;

namespace MatrixTranspose
{
    public class Transposing
    {
        public int[,] TransposeRowsAndColumns(int [,] arr)
        {
            int rowCount = arr.GetLength(0);
            int columnCount = arr.GetLength(1);
            int [,] transposed = new int[columnCount, rowCount];
            
                transposed = (int[,])arr.Clone();
                for (int i = 1; i < rowCount; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                    int temp = transposed[i, j];
                    transposed[i, j] = transposed[j, i];
                    transposed[j, i] = temp;
                    }
                }
           return transposed;
        }
    }
}
