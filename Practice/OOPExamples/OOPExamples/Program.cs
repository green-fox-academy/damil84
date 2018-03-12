using System;
using OOPExamples;

class Program
{
    static void Main(string[] args)
    {
        var comp = new Computer("Generic PC");
        var isComputer = comp is Computer;

        Console.WriteLine("Computer type - " + comp.GetType());
        Console.WriteLine("Is computer - " + isComputer);
        Console.WriteLine("Computer name - " + comp.Name);

        Console.ReadLine();
    }
}
