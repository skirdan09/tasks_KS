namespace task_06_03
{
    using System;

    class Program
    {
        static void Calculate(int a, int b, out int sum, out int difference, out int product)
        {
            sum = a + b;
            difference = a - b;
            product = a * b;
        }

        static void Main()
        {
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());

            Calculate(a, b, out int sum, out int difference, out int product);

            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Разность: " + difference);
            Console.WriteLine("Произведение: " + product);
        }
    }
}