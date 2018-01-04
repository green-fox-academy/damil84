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
            var printer = new Printer();
            printer.Print(myArray);
            Console.WriteLine();

            var transposing = new Transposing();
            int[,] transposedMyArray = myArray;
            printer.Print(transposing.TransposeRowsAndColumns(transposedMyArray));
            Console.ReadLine();
        }
    }
}
