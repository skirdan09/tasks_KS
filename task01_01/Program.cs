using System.Security.Cryptography;

namespace task01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string b = Console.ReadLine();
          
            if (int.TryParse(a, out int result))
            {
                Console.WriteLine("Произведение :" + HMACSH);
            }

        }
    }
}


