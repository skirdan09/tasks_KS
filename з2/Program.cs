namespace з2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] array = new string[size];
            for(int i = 0; i < size; i++)
            {
                array[i] = Console.ReadLine();
            }
            Random rnd = new Random();
            rnd.Shuffle(array);
            foreach (string el in array)
                Console.WriteLine(el);

            /*
                Read "4"
                int.Parse("4") - 4
                size = 4

            ["", "", "", ""]

            int i = 0;
            0 < 4;
            Read "one"
            array[0] = "one"; ["one", "", "", ""]
            i++ - i = 1;

            1 < 4
            "two"
            array[1] = "two"    ["one", "two", "", ""]
            i = 2

            2 < 4
            "three"
            array[2] = "three"  ["one", "two", "three", ""]
            3

            3 < 4
            "four"
            array[3] = "four"   ["one", "two", "three", "four"]
            4

            4 < 4 - цикл закончился

            string el

            el = "one"
            Write "one"

            el = "two"
            write "two"
            
            el = "three"
            write "three"

            el = "four"
            write "four"



             */
        }
    }
}
