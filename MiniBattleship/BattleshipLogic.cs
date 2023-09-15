using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniBattleship
{
    public static class BattleshipLogic
    {
        public static void PressEnterToContinue()
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        public static string[] MakeBattlefieldGrid()
        {
            string[] grid = new string[25];
            string[] rows = { "A", "B", "C", "D", "E" };
            int numberInArray = 0;
            int numberOfColumns = 5;
            foreach (string row in rows)
            {
                for (int i = 1; i <= numberOfColumns; i++)
                {
                    string gridBox = $"{row}{i}";
                    grid[numberInArray] = gridBox;
                    numberInArray++;
                }
            }

            return grid;
        }

        public static void PrintGrid(string[] grid)
        {
            int numberOfColumns = 5;

            string rowA = string.Join(" ", grid, 0, numberOfColumns);
            string rowB = string.Join(" ", grid, numberOfColumns, numberOfColumns);
            string rowC = string.Join(" ", grid, numberOfColumns * 2, numberOfColumns);
            string rowD = string.Join(" ", grid, numberOfColumns * 3, numberOfColumns);
            string rowE = string.Join(" ", grid, numberOfColumns * 4, numberOfColumns);

            Console.WriteLine(rowA);
            Console.WriteLine(rowB);
            Console.WriteLine(rowC);
            Console.WriteLine(rowD);
            Console.WriteLine(rowE);
        }

        public static string[] GridUpdate(string[] grid, string positionOnTheGrid, string changedValue)
        {
            int indexOfSelectedPosition = Array.IndexOf(grid, positionOnTheGrid);
            grid[indexOfSelectedPosition] = changedValue;

            return grid;
        }

    }
}
