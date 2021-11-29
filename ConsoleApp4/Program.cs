using GameOfLife;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 2;
            int columns = 2;
            Game target = new Game(rows, columns);
            target.ToggleGridCell(0, 0);
            target.ToggleGridCell(0, 1);
            target.ToggleGridCell(1, 0);
            target.ToggleGridCell(1, 1);
            target.MaxGenerations = 100;// This pattern remains unchanged for infinite generation, testing it for 100 generations
            target.Init();
            Console.WriteLine(target.ToString());
            Console.WriteLine(target.InputGrid[0, 0].IsAlive);
            Console.WriteLine(target.InputGrid[1, 0].IsAlive);
            Console.WriteLine(target.InputGrid[1, 1].IsAlive);
            Console.ReadLine();

            rows = 7;
            columns = 4;
            target = new Game(rows, columns);
            target.ToggleGridCell(0, 0);
            target.ToggleGridCell(0, 1);
            target.ToggleGridCell(1, 2);
            target.ToggleGridCell(2, 3);
            target.ToggleGridCell(3, 3);
            target.ToggleGridCell(4, 3);
            target.ToggleGridCell(5, 2);
            target.ToggleGridCell(6, 0);
            target.ToggleGridCell(6, 1);
            target.MaxGenerations = 100;
            target.Init();
            Console.WriteLine(target.InputGrid[4, 1].IsAlive);
            Console.WriteLine(target.InputGrid[4, 2].IsAlive);
            Console.WriteLine(target.InputGrid[5, 0].IsAlive);
            Console.WriteLine(target.InputGrid[5, 3].IsAlive);
            Console.WriteLine(target.InputGrid[6, 1].IsAlive);
            Console.WriteLine(target.InputGrid[6, 2].IsAlive);
            Console.WriteLine(target.InputGrid[3, 8].IsAlive);
            Console.WriteLine(target.InputGrid[4, 7].IsAlive);
            Console.WriteLine(target.InputGrid[4, 9].IsAlive);
            Console.WriteLine(target.InputGrid[5, 6].IsAlive);
            Console.WriteLine(target.InputGrid[5, 10].IsAlive);
            Console.WriteLine(target.InputGrid[6, 6].IsAlive);
            Console.WriteLine(target.InputGrid[6, 10].IsAlive);
            Console.WriteLine(target.InputGrid[7, 7].IsAlive);
            Console.WriteLine(target.InputGrid[7, 8].IsAlive);
            Console.WriteLine(target.InputGrid[7, 9].IsAlive);
            Console.WriteLine(target.InputGrid[9, 7].IsAlive);
            Console.WriteLine(target.InputGrid[9, 8].IsAlive);
            Console.WriteLine(target.InputGrid[9, 9].IsAlive);
            Console.WriteLine(target.InputGrid[10, 6].IsAlive);
            Console.WriteLine(target.InputGrid[10, 10].IsAlive);
            Console.WriteLine(target.InputGrid[11, 6].IsAlive);
            Console.WriteLine(target.InputGrid[11, 10].IsAlive);
            Console.WriteLine(target.InputGrid[12, 7].IsAlive);
            Console.WriteLine(target.InputGrid[12, 9].IsAlive);
            Console.WriteLine(target.InputGrid[13, 8].IsAlive);
            Console.ReadLine();
            rows = 1;
            columns = 10;
            target = new Game(rows, columns);

            target.ToggleGridCell(0, 0);
            target.ToggleGridCell(0, 1);
            target.ToggleGridCell(0, 2);
            target.ToggleGridCell(0, 3);
            target.ToggleGridCell(0, 4);
            target.ToggleGridCell(0, 5);
            target.ToggleGridCell(0, 6);
            target.ToggleGridCell(0, 7);
            target.ToggleGridCell(0, 8);
            target.ToggleGridCell(0, 9);
            target.MaxGenerations = 50;
            target.Init();
            Console.WriteLine(target.ToString());
            Console.WriteLine(target.InputGrid[4, 2].IsAlive);
            Console.WriteLine(target.InputGrid[3, 3].IsAlive);
            Console.WriteLine(target.InputGrid[4, 3].IsAlive);
            Console.WriteLine(target.InputGrid[5, 3].IsAlive);
            Console.WriteLine(target.InputGrid[2, 4].IsAlive);
            Console.WriteLine(target.InputGrid[3, 4].IsAlive);
            Console.WriteLine(target.InputGrid[4, 4].IsAlive);
            Console.WriteLine(target.InputGrid[5, 4].IsAlive);
            Console.WriteLine(target.InputGrid[6, 4].IsAlive);

            Console.WriteLine(target.InputGrid[4, 13].IsAlive);
            Console.WriteLine(target.InputGrid[3, 12].IsAlive);
            Console.WriteLine(target.InputGrid[4, 12].IsAlive);
            Console.WriteLine(target.InputGrid[5, 12].IsAlive);
            Console.WriteLine(target.InputGrid[2, 11].IsAlive);
            Console.WriteLine(target.InputGrid[3, 11].IsAlive);
            Console.WriteLine(target.InputGrid[4, 11].IsAlive);
            Console.WriteLine(target.InputGrid[5, 11].IsAlive);
            Console.WriteLine(target.InputGrid[6, 11].IsAlive);
            Console.ReadLine();
        }
    }
}