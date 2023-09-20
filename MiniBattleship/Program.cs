
using MiniBattleship;
using System.Data;
using System.Text;

int numberOfShips = 5;
string[] battlefieldGrid = new string[25];
List<string> player1ShipsPositions = new List<string>();
List<string> player2ShipsPositions = new List<string>();
string[] player1Battlefield = new string[25];
string[] player2Battlefield = new string[25];
string[] player1ShotsGrid = new string[25];
string[] player2ShotsGrid = new string[25];
List<string> player1ShotsPositions = new List<string>();
List<string> player2ShotsPositions = new List<string>();

////not used only for now!
////Messages.WelcomeMessage();

//(string player1, string player2) = GetInfo.GetPlayersNames();

//Making basic battlefield
battlefieldGrid = BattleshipLogic.MakeBattlefieldGrid();

////Making players battlefields
//player1Battlefield = BattleshipLogic.CopyBattlefield(battlefieldGrid);
//player2Battlefield = BattleshipLogic.CopyBattlefield(battlefieldGrid);

//Messages.PlayerTurnMessage(player1);
//(player1Battlefield, player1ShipsPositions) = GetInfo.GetPositionOfTheShips(player1Battlefield, numberOfShips);
//Messages.PlayerBattlefield(player1Battlefield);

//Messages.PlayerTurnMessage(player2);
//(player2Battlefield, player2ShipsPositions) = GetInfo.GetPositionOfTheShips(player2Battlefield, numberOfShips);
//Messages.PlayerBattlefield(player2Battlefield);

////Shooting ships
player1ShotsGrid = BattleshipLogic.CopyBattlefield(battlefieldGrid);
player2ShotsGrid = BattleshipLogic.CopyBattlefield(battlefieldGrid);
string winningPlayer = "";

string player1 = "Steve";
string player2 = "Bob";


player1ShipsPositions.Add("A1");
player1ShipsPositions.Add("A2");
player1ShipsPositions.Add("A3");
player1ShipsPositions.Add("A4");
player1ShipsPositions.Add("A5");

player2ShipsPositions.Add("A1");
player2ShipsPositions.Add("A2");
player2ShipsPositions.Add("A3");
player2ShipsPositions.Add("A4");
player2ShipsPositions.Add("A5");


do
{
    Messages.PlayerTurnMessage(player1);
    BattleshipLogic.ShootShip(player1ShotsGrid, player1ShotsPositions, player2ShipsPositions);
    if (BattleshipLogic.WinCheck(player1ShotsPositions) == true)
    {
        winningPlayer = $"{player1}";
        break;
    }

    Messages.PlayerTurnMessage(player2);
    BattleshipLogic.ShootShip(player2ShotsGrid, player2ShotsPositions, player1ShipsPositions);
    if (BattleshipLogic.WinCheck(player1ShotsPositions) == true)
    {
        winningPlayer = $"{player2}";
        break;
    }

} while (winningPlayer == "");

Messages.WinMessage(winningPlayer);
Messages.ThanksForPlaying();

Console.ReadLine();


