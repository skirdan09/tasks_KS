namespace task03_03
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int secret = random.Next(0, 101); // число от 0 до 100
            int[] array = new int[1000];
            int count = 0;

            Console.WriteLine("Угадайте число от 0 до 100");

            while (true)
            {
                Console.Write("Введите число: ");
                int num = int.Parse(Console.ReadLine());

                array[count] = num;
                count++;

                if (num == secret)
                {
                    Console.WriteLine("Верно! Количество попыток: " + count);
                    break;
                }
                else if (num < secret)
                {
                    Console.WriteLine("Больше");
                }
                else
                {
                    Console.WriteLine("Меньше");
                }
            }
        }
    }
}