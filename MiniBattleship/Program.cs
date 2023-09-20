
using MiniBattleship;
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

//not used only for now!
//Messages.WelcomeMessage();

(string player1, string player2) = GetInfo.GetPlayersNames();

//Making basic battlefield
battlefieldGrid = BattleshipLogic.MakeBattlefieldGrid();

//Making players battlefields
player1Battlefield = BattleshipLogic.CopyBattlefield(battlefieldGrid);
player2Battlefield = BattleshipLogic.CopyBattlefield(battlefieldGrid);

Messages.PlayerTurnMessage(player1);
(player1Battlefield, player1ShipsPositions)  = GetInfo.GetPositionOfTheShips(player1Battlefield, numberOfShips);
Messages.PlayerBattlefield(player1Battlefield);

Messages.PlayerTurnMessage(player2);
(player2Battlefield, player2ShipsPositions) = GetInfo.GetPositionOfTheShips(player2Battlefield, numberOfShips);
Messages.PlayerBattlefield(player2Battlefield);

//Shooting ships
player1ShotsGrid = BattleshipLogic.CopyBattlefield(battlefieldGrid);
player2ShotsGrid = BattleshipLogic.CopyBattlefield(battlefieldGrid);

do
{
		Messages.PlayerTurnMessage(player1);
        BattleshipLogic.ShootShip(player1ShotsGrid, player1ShotsPositions, player2ShipsPositions);
		if (BattleshipLogic.WinCheck(player1ShotsPositions) == true)
		{
		break;
		}

		Messages.PlayerTurnMessage(player2);
		BattleshipLogic.ShootShip(player2ShotsGrid, player2ShotsPositions, player1ShipsPositions);

} while (BattleshipLogic.WinCheck(player2ShotsPositions) == false);



//WinMessage(); +thanks for playing