namespace _13_1z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\NewFolder/file.txt";
            string a;
            a = Console.ReadLine();
            File.WriteAllText(path, a);
            string result = File.ReadAllText(path);
            Console.WriteLine(result);
        }
    }
}
