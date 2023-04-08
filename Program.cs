Console.WriteLine("The Fountain of Objects 0.3");

GameMode selMode = GameMode.medium;
bool correctMode = false;
bool win = false;
bool activeFountain = false;
Room tempRoom;
string? action;
Action playerAction;

while(true){

    Console.Write("Select difficulty level:\n1-Easy\n2-Medium\n3-Hard\n");

    string? playerChoice = Console.ReadLine();

    switch(playerChoice){

        case "1":
        selMode = GameMode.easy;
        correctMode = true;
        break;

        case "2":
        selMode = GameMode.medium;
        correctMode = true;
        break;

        case "3":
        selMode = GameMode.hard;
        correctMode = true;
        break;

        default:
        Console.WriteLine("Invalid choice!!!");
        break;
    
    }

    if(correctMode == true){
        break;
    }

}

Grid board = new Grid(selMode);
Player newPlayer = new Player(board.Size.X);
Maelstron[] enemyArr = board.maelsArray;

do{
    //Manages Maelstron enemies
    foreach(Maelstron m in enemyArr){
        if(newPlayer.getPlayerCoord() == m.getCoord()){

            newPlayer.movePlayer(m.affectPlayer(newPlayer.getPlayerCoord(), board.Size.X));
            m.updateEnemyCoord(board.Size.X);
            board.maelstronEffect();
        }
    }

    tempRoom = board.returnRoom(newPlayer.getPlayerCoord());
    Console.WriteLine($"You are in a room at (X = {newPlayer.getPlayerCoord().Item1} Y = {newPlayer.getPlayerCoord().Item2})");
    tempRoom.showDescription();
    Console.WriteLine("What do you want to do?");

    action = Console.ReadLine()?.ToLower();

    playerAction = decideAction(action);

    if(playerAction == Action.UNKNOWN){

        continue;

    }

    activeFountain = newPlayer.playerAction(playerAction, board.FountainCoordinate);

    if((activeFountain == true) && (board.FRoom.Activated != true)){
        board.updateFountainRoom();
    }

    win = verifyWinCond(activeFountain, newPlayer.getPlayerCoord());

} while(win == false);

Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
Console.WriteLine("You won!");


bool verifyWinCond(bool activedFountain, (int X, int Y) playerCoord){

    if(activedFountain == true && (playerCoord == (0,0))){
        return true;
    } 

    return false;

}



Action decideAction(string input){

    switch(input){
        case "move north":
        return Action.MOVE_NORTH;

        case "move south":
        return Action.MOVE_SOUTH;

        case "move west":
        return Action.MOVE_WEST;

        case "move east":
        return Action.MOVE_EAST;

        case "enable":
        return Action.ENABLE;

        default:
        Console.WriteLine("Sorry, didn't get that. Use move north, move south, move west,  move east, enable");
        return Action.UNKNOWN;
    }


}



public enum GameMode {easy, medium, hard};

public enum Action{
    MOVE_NORTH,
    MOVE_SOUTH,
    MOVE_WEST,
    MOVE_EAST,
    ENABLE,
    DISABLE,

    UNKNOWN
}