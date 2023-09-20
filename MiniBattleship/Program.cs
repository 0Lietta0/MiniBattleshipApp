
using MiniBattleship;
using System.Text;

int numberOfShips = 5;
string[] battlefieldGrid = new string[25];
string[] player1ShipPositions = new string[5];
string[] player2ShipPositions = new string[5];
string[] player1Battlefield = new string[25];
string[] player2Battlefield = new string[25];
string[] player1ShotsGrid = new string[25];
string[] player2ShotsGrid = new string[25];

//not used only for now!
//Messages.WelcomeMessage();

(string player1, string player2) = GetInfo.GetPlayersNames();

//Making basic battlefield
battlefieldGrid = BattleshipLogic.MakeBattlefieldGrid();

//Making players battlefields
player1Battlefield = BattleshipLogic.CopyBattlefield(battlefieldGrid);
player2Battlefield = BattleshipLogic.CopyBattlefield(battlefieldGrid);

Messages.PlayerTurnMessage(player1);
(player1ShipPositions, player1Battlefield)  = GetInfo.GetPositionOfTheShips(player1Battlefield, numberOfShips);
Messages.PlayerBattlefield(player1Battlefield);

Messages.PlayerTurnMessage(player2);
(player2ShipPositions, player2Battlefield) = GetInfo.GetPositionOfTheShips(player2Battlefield, numberOfShips);
Messages.PlayerBattlefield(player2Battlefield);

//Shooting ships
player1ShotsGrid = BattleshipLogic.CopyBattlefield(battlefieldGrid);
player2ShotsGrid = BattleshipLogic.CopyBattlefield(battlefieldGrid);

bool playerWins = false;
do
{
	Messages.PlayerTurnMessage(player1);
	BattleshipLogic.ShootShip(player1ShotsGrid,player2ShipPositions);
	Console.ReadLine();


} while (playerWins == false);

//    do
//    {
//        Turns(max 25)
//    player 1 choose
//    Print grid
//    if (right)
//        {
//            ship sinks
//    Change the place to X
//    }
//        else
//        {
//            change the place to -
//            the end of round
//        }
//        pleyer2 choose...
//}
//    while (players1AllShipsSinked == false && players2AllShipsSinked == false)

//WinMessage(); +thanks for playing