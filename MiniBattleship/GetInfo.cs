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

            return (player1, player2);

        }
        public static string GetPositionOnTheGrid(string[] grid)
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
                    isValidPlace = true;
                    positionOnTheGrid = readResult.Trim().ToUpper();

                    if (grid.Contains(positionOnTheGrid) == false)
                    {
                        positionOnTheGrid = "";
                        Console.WriteLine("This position does not exist on the battlefield or is already occupied. " +
                            "Choose one of the A1-E5 positions currently shown on the screen.");
                    }
                }
            } while (isValidPlace == false || positionOnTheGrid == "");

            return positionOnTheGrid;

        }
        public static (string[], string[]) GetPositionOfTheShips(string[] battlefieldGrid, int numberOfShips)
        {
            string[] shipsPositions = new string[numberOfShips];
            string[] playerGrid = new string[25];
            Array.Copy(battlefieldGrid, playerGrid,25);

            for (int i = 0; i < numberOfShips; i++)
            {
                string shipPosition = "";
                Console.Clear();
                Messages.PlaceShipsMessage(numberOfShips - i);
                BattleshipLogic.PrintGrid(playerGrid);
                shipPosition = GetPositionOnTheGrid(playerGrid);
                playerGrid = BattleshipLogic.GridUpdate(playerGrid, shipPosition, "x ");
                shipsPositions[i] = shipPosition;
            }

            return (shipsPositions, playerGrid);
        }
    }
}
