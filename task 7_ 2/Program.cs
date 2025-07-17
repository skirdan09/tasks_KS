namespace task_7__2
{
    class Elevator
    {
        public int TotalFloors;
        public int CurrentFloor = 1;

        public Elevator(int totalFloors)
        {
            if (totalFloors < 1)
            {
                Console.WriteLine("Количество этажей должно быть не меньше 1");
                TotalFloors = 1;
            }
            else
            {
                TotalFloors = totalFloors;
            }
        }
        public void GoUp(int floors)
        {
            if (floors < 0)
            {
                Console.WriteLine("Нельзя подниматься на отрицательное число этажей");
                return;
            }
            CurrentFloor += floors;
            if (CurrentFloor > TotalFloors)
                CurrentFloor = TotalFloors;

            Console.WriteLine($"Лифт сейчас на {CurrentFloor} этаже");
        }
        public void GoDown(int floors)
        {
            if (floors < 0)
            {
                Console.WriteLine("Нельзя опускаться на отрицательное число этажей");
                return;
            }
            CurrentFloor -= floors;
            if (CurrentFloor < 1)
                CurrentFloor = 1;

            Console.WriteLine($"Лифт сейчас на {CurrentFloor} этаже");
        }
    }
    class Program
    {
        static void Main()
        {
            var elevator = new Elevator(10);

            elevator.GoUp(3);
            elevator.GoUp(10);
            elevator.GoDown(5);
            elevator.GoDown(10);
        }
    }
}