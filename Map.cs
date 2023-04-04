public class Grid{

    private Room[,] gameMap;
    private (int, int) playerPosition;

    public Grid(GameMode selectedDif){

        switch(selectedDif){

            case GameMode.easy:
            this.gameMap = new Room[4,4];
            break;

            case GameMode.medium:
            this.gameMap = new Room[5,5];
            break;

            case GameMode.hard:
            this.gameMap = new Room[7,7];
            break;
        }
    }

    public (int, int) verifyPlayerPosition(){
        return this.playerPosition;
    }

    public void updatePlayerPos((int, int) pos){

        this.playerPosition = pos;

    }

    private void populateGrid(){

        for(int i = 0; i < 4; i++){

            




        }

    }



}