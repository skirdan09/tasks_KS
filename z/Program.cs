using System.ComponentModel.Design;

namespace z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2025, 08, 07);
            PrintWeekdend(date);

            date = new DateTime(2025, 08, 08);
            PrintWeekdend(date);

            date = new DateTime(2025, 08, 09);
            PrintWeekdend(date);
        }
        
        static void PrintWeekdend(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("выходной");
            }
            else
            {
                Console.WriteLine("рабочий день");
            }
        }
    }
}
