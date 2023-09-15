
using MiniBattleship;
using System.Text;

int numberOfShips = 5;
string[] battlefieldGrid = new string[25];
string[] player1ShipPositions = new string[5];
string[] player2ShipPositions = new string[5];
string[] player1Battlefield = new string[25];
string[] player2Battlefield = new string[25];

//not used only for now!
//Messages.WelcomeMessage();

//(string player1, string player2) = BattleshipLogic.GetPlayersNames();

battlefieldGrid = BattleshipLogic.MakeBattlefieldGrid();

(player1ShipPositions, player1Battlefield)  = GetInfo.GetPositionOfTheShips(battlefieldGrid, numberOfShips);
Messages.PlayerBattlefield(player1Battlefield);

(player2ShipPositions, player2Battlefield) = GetInfo.GetPositionOfTheShips(battlefieldGrid, numberOfShips);
Messages.PlayerBattlefield(player2Battlefield);

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