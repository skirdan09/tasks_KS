namespace task03_01
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            int min = Math.Min(a, b);
            int max = Math.Max(a, b);

            Random rnd = new Random();
            int size = max - min + 1;
            int[] numbers = new int[size];
            int[] squares = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(min, max + 1);
                squares[i] = numbers[i] * numbers[i];
            }
            Console.WriteLine("Сгенерированы числа и их квадраты:");
            for (int i = 0; i < size; i++)
            {

            }
        }
    }
}
