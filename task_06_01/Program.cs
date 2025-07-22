namespace task_06_01
{
    using System;

    class Program
    {

        static void Print(params string[] words)
        {
            Console.WriteLine(string.Join(" ", words));
        }

        static void Main()
        {
            Print("Привет", "пока");
            
        }
    }


}