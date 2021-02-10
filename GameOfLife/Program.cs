using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // The period-15 oscillator pattern
            Game objLifeGame = new Game(1, 10);
            objLifeGame.ToggleGridCell(0, 0);
            objLifeGame.ToggleGridCell(0, 1);
            objLifeGame.ToggleGridCell(0, 2);
            objLifeGame.ToggleGridCell(0, 3);
            objLifeGame.ToggleGridCell(0, 4);
            objLifeGame.ToggleGridCell(0, 5);
            objLifeGame.ToggleGridCell(0, 6);
            objLifeGame.ToggleGridCell(0, 7);
            objLifeGame.ToggleGridCell(0, 8);
            objLifeGame.ToggleGridCell(0, 9);
            objLifeGame.MaxGenerations = 10;
            objLifeGame.Init();

            Console.ReadKey();            
        }
    }
}
