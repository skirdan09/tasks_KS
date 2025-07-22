namespace task06_02
{
    using System;

    class Program
    {
        static int FindFirstCommaIndex(string input)
        {
            return input.IndexOf(',');
        }
        static void Main()
        {
            Console.WriteLine("Введите строку:");
            string userInput = Console.ReadLine();

            int index = FindFirstCommaIndex(userInput);

            Console.WriteLine("Индекс первой запятой: " + index);
        }
    }
}