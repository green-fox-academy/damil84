using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Sum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.SummingMachine());
            Console.WriteLine(p.SummingMachineIsNull());
            Console.ReadLine();
        }

        public int SummingMachine()
            {
            var listOfSum = new List<int>();
            listOfSum.Add(0);
            listOfSum.Add(1);
            listOfSum.Add(2);

            int sum = 0;
            for (int i = 0; i < listOfSum.Count; i++)
            {
                sum += listOfSum[i];
            }
            return sum;
            }

        public int SummingMachineIsNull()
        {
            List<int> listNull = null;
            Console.WriteLine(listNull == null);

            int sumNull = 0;
            for (int i = 0; i < listNull.Count; i++)
            {
                sumNull += listNull[i];
            }
            return sumNull;
        }

    }
}