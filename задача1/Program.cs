namespace задача1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Банан");
            set.Add("Груша");
            set.Add("Апельсин");

            HashSet<string> set1 = new HashSet<string>();
            set1.Add("Банан");
            set1.Add("Яблоко");
            set1.Add("Киви");


            foreach (string value in set)
            {
                if (set1.Contains(value))
                {
                    Console.WriteLine(value);
                }
            }
            foreach (string value in set)
            {
                Console.WriteLine(value);
            }
            foreach (string value in set1)
            {
                if (!set.Contains(value))
                Console.WriteLine(value);

            }

        }
    }
}
