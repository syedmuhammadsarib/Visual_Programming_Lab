using System;

namespace Lab4
{
    class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Task1();
            Console.WriteLine("\nTask 2:");
            string result = Task2("hello and welcome to this demo!");
            Console.WriteLine(result);

            Console.WriteLine("\nTask 3:");
            string mergedResult = Task3(new string[] { "apple", "orange", "banana" });
            Console.WriteLine(mergedResult);

            Console.WriteLine("\nTask 4:");
            int[,] array2D = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Task4(array2D);
        }

        static void Task1()
        {
            int[] array = { 0, 0, 0, 0, 0 };

            for (int i = 0; i < 40; i++)
            {
                Console.Write("Enter Student " + (i + 1) + " Response: ");
                int user_input = Convert.ToInt32(Console.ReadLine());
                user_input = check(user_input);
                array[user_input - 1]++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Response " + (i + 1) + " given by : " + array[i] + " people");
            }
        }

        static int check(int value)
        {
            while (true)
            {
                if (value >= 1 && value <= 5)
                {
                    return value;
                }
                Console.WriteLine("Enter Correct Value [1-5] : ");
                value = Convert.ToInt32(Console.ReadLine());
            }
        }

        static string Task2(string value)
        {
            string[] vowel_array = new string[0]; // Initialize the array properly
            int start = 0;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == ' ')
                {
                    bool check = false;
                    string word = "";
                    for (int j = start; j < i; j++)
                    {
                        word += value[j];
                        if (value[j] == 'A' || value[j] == 'a' || value[j] == 'E' || value[j] == 'e' || value[j] == 'I' || value[j] == 'i' || value[j] == 'O' || value[j] == 'o' || value[j] == 'U' || value[j] == 'u')
                        {
                            check = true;
                        }
                    }

                    if (check == true && (word.Length != 4 && word.Length != 5))
                    {
                        check = false;
                    }

                    if (check == true)
                    {
                        Array.Resize(ref vowel_array, vowel_array.Length + 1);
                        vowel_array[vowel_array.Length - 1] = word;
                    }

                    start = i + 1;
                }
            }

            return Task3(vowel_array);
        }

        static string Task3(string[] pass_array)
        {
            string value = "";
            foreach (string pass in pass_array)
            {
                value += pass;
            }
            return value;
        }

        static void Task4(int[,] pass_array)
        {
            Console.Write("2D Integer Array Values : { ");
            foreach (int i in pass_array)
            {
                Console.Write(i + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }
};
