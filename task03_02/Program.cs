namespace task03_02
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            char[] array = new char[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                // Генерация случайной буквы от 'a' до 'z'
                array[i] = (char)rnd.Next('a', 'z' + 1);
            }
            
            Console.WriteLine("Сгенерированный массив случайных букв:");
            foreach (char el in array)
                Console.WriteLine(el + "");
        }
    }
}
