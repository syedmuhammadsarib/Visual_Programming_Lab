using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int[,,] array3d = new int[3, 3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write($"Enter value at matrix[{i},{j},{k}]: ");
                    array3d[i, j, k] = int.Parse(Console.ReadLine());
                }
            }
        }

        //Functio to display diagonal
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("\nThis is dimention " + (i + 1));
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(array3d[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        int result = 0;

        //Sum of Diagonal 
        for (int i = 0; i < 3; i++)
        {
            result += array3d[i, i, i];
        }
        Console.WriteLine(" Sum of diagonal is : " + result);
    }
}

