namespace practice_1
{
    internal class Program
    {
        static readonly char[,] map = {
        { '#', '#', '#', '#', '#', '#', '#' },
        { '#', ' ', ' ', '#', ' ', ' ', '#' },
        { '#', ' ', '#', '#', ' ', '#', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', '#', '#', '*', '#', '#' },
        { '#', '#', '#', '#', '#', '#', '#' }
    };

        static int x = 1, y = 1;

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < map.GetLength(0); i++, Console.WriteLine())
                    for (int j = 0; j < map.GetLength(1); j++)
                        Console.Write(i == y && j == x ? 'P' : map[i, j]);

                if (map[y, x] == '*')
                {
                    Console.WriteLine("Поздравляем, Вы достигли финиша!");
                    break;
                }

                (int dy, int dx) = Console.ReadKey(true).Key switch
                {
                    ConsoleKey.W => (-1, 0),
                    ConsoleKey.S => (1, 0),
                    ConsoleKey.A => (0, -1),
                    ConsoleKey.D => (0, 1),
                    _ => (0, 0)
                };

                int nx = x + dx, ny = y + dy;
                if (ny >= 0 && ny < map.GetLength(0) && nx >= 0 && nx < map.GetLength(1) && map[ny, nx] != '#')
                {
                    x = nx; y = ny;
                }
            }
        }
    }
        
          
    
}
