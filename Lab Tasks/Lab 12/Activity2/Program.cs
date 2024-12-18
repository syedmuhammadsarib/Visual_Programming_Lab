// See https://aka.ms/new-console-template for more information
using System;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three parts of LINQ query:

            //1. Data source
            int[] numbers = {0, 1, 2, 3, 4, 5 ,6};

            //2. Query creation
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            //3. Query execution
            foreach (int num in numQuery)
            {
                Console.WriteLine("{0,1}", num);
            }
        }
    }
}
  