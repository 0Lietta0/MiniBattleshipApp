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

        public static string[,] MakeBattlefieldGrid()
        {
            string[,] grid = new string[5, 5];
            string[] rows = { "A", "B", "C", "D", "E" };

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 1 ; j <= grid.GetLength(1); j++)
                {
                    grid[i, j-1] = $"{rows[i]}{j}";
                }
            }

            return grid;
        }

        public static void PrintGrid(string[,] grid)
        {
            for(int i = 0; i < grid.GetLength(0); i++)
            {
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write($"{grid[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public static string[,] GridUpdate(string[,] grid, string positionOnTheGrid, string changedValue)
        {
            for ( int i = 0; i < grid.GetLength(0); i++)
            { 
                for(int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i,j] == positionOnTheGrid)
                    {
                        grid[i,j] = changedValue;
                    }
                }
                    
            }

            return grid;
        }

        public static string[,] CopyBattlefield(string[,] battlefieldGrid)
        {
            string[,] newGrid = new string[5, 5];
            Array.Copy(battlefieldGrid, newGrid, 25);

            return newGrid;
        }

        public static List<string> ShootShip(string[,] playerShotsGrid, List<string> playerShotsPositions, List<string> opponentShipsPositions)
        {
            Console.Clear();

            Messages.ShootShipMessage();
            PrintGrid(playerShotsGrid);
            Console.WriteLine();
            string shotPosition = GetInfo.GetPositionOnTheGrid(playerShotsGrid);
            if (opponentShipsPositions.Contains(shotPosition))
            {
                GridUpdate(playerShotsGrid, shotPosition, "x ");
                Console.WriteLine();
                Console.WriteLine("Congartulations! One ship is down.");
                playerShotsPositions.Add(shotPosition);
            }
            else
            {
                GridUpdate(playerShotsGrid, shotPosition, "~ ");
                Console.WriteLine();
                Console.WriteLine("You missed.");
            }

            PressEnterToContinue();

            return playerShotsPositions;
        }

        public static bool WinCheck(List<string> playerShotsPositions)
        {
            if(playerShotsPositions.Count == 5)
            {
                return true;
            }
            else return false;
        }
    }
}
