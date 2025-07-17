namespace task7_1
{


    class Figure
    {
        public int Angles;
        public string Color;

        public Figure(int angles, string color)
        {
            Angles = angles;
            Color = color;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Фигура с {Angles} углами, цвет: {Color}");
        }
    }

    class Program
    {
        static void Main()
        {
            var figure1 = new Figure(4, "Красный");
            var figure2 = new Figure(3, "Синий");

            figure1.PrintInfo();
            figure2.PrintInfo();
        }
    }
}