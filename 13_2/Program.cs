namespace _13_2
{
    internal class Program
    {
        public static bool OpenRead { get; private set; }

        static void Main(string[] args)
        {
            string path = "C:\\NewFile/file.txt";
            Console.WriteLine("Введите текст");
            string a;
            a = Console.ReadLine();
            Console.WriteLine("Напишите quit,чтобы сохранить текст в файл");
            FileInfo file = new FileInfo(path);
            if (OpenRead)
      
        }
    }
}
