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
            Size = (4,4);
            break;

            case GameMode.medium:
            this.gameMap = new Room[5,5];
            Size = (5,5);
            break;

            case GameMode.hard:
            this.gameMap = new Room[7,7];
            Size = (7,7);
            break;
        }


        populateGrid(Size);


    }

    private void populateGrid((int X, int Y) size){


        for(int i = 0; i < size.X; i++){

            for(int j = 0; j < size.Y; j++){

                if(i == 0 && j == 0){

                    this.gameMap[0,0] = new CaveEntreance();

                } else if(i == 0 && j ==2){

                    this.gameMap[0,2] = FRoom;
                    this.FountainCoordinate = (i,j);

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