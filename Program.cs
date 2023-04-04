Console.WriteLine("The Fountain of Objects 0.3");

GameMode selMode = GameMode.medium;
bool correctMode = false;

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












public enum GameMode {easy, medium, hard};