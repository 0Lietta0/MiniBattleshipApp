using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBattleship
{
    public static class GetInfo
    {
        public static (string, string) GetPlayersNames()
        {
            bool isValidName = false;
            string player1 = "";
            string player2 = "";

            Console.Clear();
            Console.WriteLine("Write down players names:");
            Console.WriteLine();
            do
            {
                Console.Write("Player1: ");
                string? readResult = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(readResult))
                {
                    Console.WriteLine("You didn't write a name.");
                }
                else
                {
                    isValidName = true;
                    player1 = readResult;
                }
            } while (isValidName == false);
            do
            {
                Console.Write("Player2: ");
                string? readResult = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(readResult))
                {
                    Console.WriteLine("You didn't write a name.");
                }
                else
                {
                    isValidName = true;
                    player2 = readResult;
                }
            } while (isValidName == false);

            BattleshipLogic.PressEnterToContinue();

            return (player1, player2);

        }
        public static string GetPositionOnTheGrid(string[,] grid)
        {
            string? readResult = "";
            bool isValidPlace = false;
            string positionOnTheGrid = "";

            do
            {
                readResult = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(readResult))
                {
                    Console.WriteLine("You didn't write anything.");
                }
                else
                {
                    positionOnTheGrid = readResult.Trim().ToUpper();

                    for (int i = 0; i < grid.GetLength(0); i++)
                    {
                        for (int j = 0; j < grid.GetLength(1); j++)
                        {
                            if (grid[i, j] != positionOnTheGrid)
                            {
                                isValidPlace = false;
                            }
                            else
                            {
                                isValidPlace = true;
                                return positionOnTheGrid;
                            }
                        }
                    }
                    if (isValidPlace == false)
                    {
                        positionOnTheGrid = "";
                        Console.WriteLine("This position does not exist on the battlefield or is already occupied. " +
                            "Choose one of the A1-E5 positions currently shown on the screen.");
                        Console.WriteLine();
                    }
                }
            } while (isValidPlace == false || positionOnTheGrid == "");

            return positionOnTheGrid;

        }
    public static (string[,], List<string>) GetPositionOfTheShips(string[,] playerGrid, int numberOfShips)
    {
        List<string> shipsPositions = new List<string>();

        for (int i = 0; i < numberOfShips; i++)
        {
            string shipPosition = "";
            Console.Clear();
            Messages.PlaceShipsMessage(numberOfShips - i);
            BattleshipLogic.PrintGrid(playerGrid);
            Console.WriteLine();
            shipPosition = GetPositionOnTheGrid(playerGrid);
            playerGrid = BattleshipLogic.GridUpdate(playerGrid, shipPosition, "x ");
            shipsPositions.Add(shipPosition);
        }

        return (playerGrid, shipsPositions);
    }
}
}
