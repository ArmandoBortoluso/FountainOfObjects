public class Grid{

    private Room[,]? gameMap;

    public (int X, int Y) Size {get;}

    public (int X, int Y) FountainCoordinate;

    public FountainRoom FRoom {get;}

    public Grid(GameMode selectedDif){

        this.FRoom = new FountainRoom();

        switch(selectedDif){

            case GameMode.easy:
            this.gameMap = new Room[4,4];
            FountainCoordinate = (0,2);
            Size = (4,4);
            break;

            case GameMode.medium:
            this.gameMap = new Room[6,6];
            FountainCoordinate = (4,5);
            Size = (6,6);
            break;

            case GameMode.hard:
            this.gameMap = new Room[8,8];
            FountainCoordinate = (2,7);
            Size = (8,8);
            break;
        }


        populateGrid(Size, FountainCoordinate);


    }

    private void populateGrid((int X, int Y) size, (int X, int Y) fountainCoord){


        for(int i = 0; i < size.X; i++){

            for(int j = 0; j < size.Y; j++){

                if(i == 0 && j == 0){

                    this.gameMap[0,0] = new CaveEntreance();

                } else if(i == fountainCoord.X && j == fountainCoord.Y){

                    this.gameMap[i,j] = FRoom;

                } else{

                    this.gameMap[i,j] = new EmptyRoom();

                }
                
            }

        }

    }

    public Room returnRoom((int X, int Y) pos){

        return(this.gameMap[pos.X, pos.Y]);
    }

    public void updateFountainRoom(){

        this.FRoom.activeFountain();

    }



}