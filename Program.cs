Console.WriteLine("The Fountain of Objects 0.3");

GameMode selMode = GameMode.medium;
bool correctMode = false;
bool win = false;
Room tempRoom;
string action;

while(true){

    Console.Write("Select difficulty level:\n1-Easy\n2-Medium\n3-Hard");

    string? playerChoice = Console.ReadLine();

    switch(playerChoice){

        case "1":
        selMode = GameMode.medium;
        correctMode = true;
        break;

        case "2":
        selMode = GameMode.medium;
        correctMode = true;
        break;

        case "3":
        selMode = GameMode.medium;
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

do{
    tempRoom = board.returnRoom(newPlayer.getPlayerCoord());
    Console.WriteLine($"You are in a room at (X = {newPlayer.getPlayerCoord().Item1} Y = {newPlayer.getPlayerCoord().Item2}");
    tempRoom.showDescription();
    Console.WriteLine("What do you want to do?");

} while(win == false);



public enum GameMode {easy, medium, hard};

public enum Action{
    MOVE_NORTH,
    MOVE_SOUTH,
    MOVE_WEST,
    MOVE_EAST,
    ENABLE,
    DISABLE
}