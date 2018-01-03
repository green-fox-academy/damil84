using System;

namespace MatrixTranspose
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[,] myArray = new int[3,3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9,}
            };
            Print print = new Print();
            print.Printer(myArray);
            Console.WriteLine();

            int[,] transposedMyArray = myArray.TransposeRowsAndColumns();
            print.Printer(transposedMyArray);
            Console.ReadLine();
        }
    }
}
