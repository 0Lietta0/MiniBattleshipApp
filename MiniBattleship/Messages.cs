using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MiniBattleship
{
    public static class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the MiniBattleShipApp!");
            Console.WriteLine("You will be fighting each other to win the game.");
            Console.WriteLine("When you shoot every ship of your oponent you win");
            Console.WriteLine("When all of your ships are shoot you lose.");
            Console.WriteLine();
            Console.WriteLine("Get ready to fight!");
            BattleshipLogic.PressEnterToContinue();
        }

        public static void PlayerTurnMessage(string player)
        {
            Console.Clear();
            Console.WriteLine($"It's {player}'s turn.");
            BattleshipLogic.PressEnterToContinue();
        }
        public static void PlaceShipsMessage(int numberOfShips)
        {
            Console.WriteLine($"You have {numberOfShips} ships left");
            Console.WriteLine("Where would you like to place your ship? (A1-E5): ");
            Console.WriteLine();
        }

        public static void PlayerBattlefield(string[] playerBattlefield)
        {
            Console.Clear();
            Console.WriteLine("Your final battlefield looks like this:");
            Console.WriteLine();
            BattleshipLogic.PrintGrid(playerBattlefield);
            BattleshipLogic.PressEnterToContinue();
        }

        public static void ShootShipMessage()
        {
            Console.WriteLine("Try to sink one of your opponents ships!");
            Console.WriteLine();
            Console.WriteLine("x stands for the ships you have sunk, ~ for your previous missed shots.");
            Console.WriteLine();
            Console.WriteLine("Choose A1-E5 position to shoot:");
            Console.WriteLine();
        }

        public static void WinMessage(string winningPlayer)
        {
            Console.Clear();

            Console.WriteLine($"{winningPlayer} wins!");
            Console.WriteLine();
            Console.WriteLine($"Congratulation {winningPlayer}!");
            BattleshipLogic.PressEnterToContinue();
        }

        public static void ThanksForPlaying()
        {
            Console.Clear();
            Console.WriteLine("Thank you for playing MiniBattleship game!");
            Console.WriteLine();
            Console.WriteLine("If you want to try one more time just relaunch the application! :]");
        }
    }
}
