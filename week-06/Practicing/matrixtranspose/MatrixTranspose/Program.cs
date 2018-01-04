using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
            var print = new Print();
            print.Printer(myArray);
            Console.WriteLine();

            //int[,] transposedMyArray = myArray.TransposeRowsAndColumns();
            var transposing = new Transposing();
            int[,] transposedMyArray = myArray;
            transposing.TransposeRowsAndColumns(transposedMyArray);
            print.Printer(transposedMyArray);
            Console.ReadLine();
        }
    }
}
