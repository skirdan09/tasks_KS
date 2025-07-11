namespace task04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину массива");
            int b = int.Parse(Console.ReadLine());
            int[,] array = new int[a, b];
            Random random = new Random();
            for (int i = 0; i < a; i++)
              for (int j = 0; j < b  ; j++)
                {
                    array[i, j] = random.Next(0;100);
                }
        

        }
    }
}
