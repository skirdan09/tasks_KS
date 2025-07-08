namespace task01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Из какой вы страны?");
            string country = Console.ReadLine();

            if (country == "Россия")
            {
                Console.WriteLine("Приветствуем вас");
            }
            else if (country == "Англия")
            {
                Console.WriteLine("Hello");
            }
            else if (country == "Франция")
            {
                Console.WriteLine("Bonjour");
            }
            else if (country == "Германия")
            {
                Console.WriteLine("Hallo");
            }
            else
            {
                Console.WriteLine("Привет");
            }
        }
    }
}
