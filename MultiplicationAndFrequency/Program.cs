using System;
using System.Linq;

namespace MultiplicationAndFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program displays numbers, multiplication of number with frequency and frequency of a number of giving array");

            int[] myTable = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var myNumber = from number in myTable
                           group number by number into y
                           select y;
            var myNumberLambda = myTable.GroupBy(number => number);

            Console.WriteLine("number number*frequency frequency");
            Console.WriteLine("First check by LINQ query");
            foreach ( var p in myNumber)
            {
                Console.WriteLine(p.Key, p.Sum(), p.Count());
            }
            Console.WriteLine("Additional check by LINQ method");
            foreach (var p in myNumberLambda)
            {
                Console.WriteLine(p.Key, p.Sum(), p.Count());
            }
            Console.ReadKey();
        }
    }
}
