public class Grid{

    private Room[,]? gameMap;

    public (int X, int Y) Size {get;}

    public (int X, int Y) FountainCoordinate;

    public FountainRoom? FRoom {get;}

    public readonly Maelstron[] maelsArray;

    private readonly GameMode mode;

    public Grid(GameMode selectedDif){


        switch(selectedDif){

            case GameMode.easy:
            this.gameMap = new Room[4,4];
            FountainCoordinate = (0,2);
            this.FRoom = new FountainRoom(FountainCoordinate);
            Size = (4,4);
            break;

            case GameMode.medium:
            this.gameMap = new Room[6,6];
            FountainCoordinate = (4,5);
            this.FRoom = new FountainRoom(FountainCoordinate);
            Size = (6,6);
            this.maelsArray = new Maelstron[1];
            break;

            case GameMode.hard:
            this.gameMap = new Room[8,8];
            FountainCoordinate = (2,7);
            this.FRoom = new FountainRoom(FountainCoordinate);
            Size = (8,8);
            this.maelsArray = new Maelstron[2];
            break;
        }

        this.mode = selectedDif;
        populateGrid(Size, FountainCoordinate);
        createEnemies(this.mode);
        maelstronEffect();


    }

    private void populateGrid((int X, int Y) size, (int X, int Y) fountainCoord){


        for(int i = 0; i < size.X; i++){

            for(int j = 0; j < size.Y; j++){

                if(i == 0 && j == 0){

                    this.gameMap[0,0] = new CaveEntreance((i,j));

                } else if(i == fountainCoord.X && j == fountainCoord.Y){

                    this.gameMap[i,j] = FRoom;

                } else{

                    this.gameMap[i,j] = new EmptyRoom((i,j));

                }
                
            }

        }

    }

    private void createEnemies(GameMode mode){

        if(mode == GameMode.medium){

            Maelstron mal = new Maelstron((2,2));
            this.maelsArray[0] = mal;

        } else if(mode == GameMode.hard){

            Maelstron mal = new Maelstron((2,2));
            Maelstron evil = new Maelstron((4,3));
            this.maelsArray[0] = mal;
            this.maelsArray[1] = evil;
        }
        else {
            return;
        }

    }

    public Room returnRoom((int X, int Y) pos){

        return(this.gameMap[pos.X, pos.Y]);
    }

    public void updateFountainRoom(){

        this.FRoom.activeFountain();

    }

    public void maelstronEffect(){

        if(this.mode == GameMode.easy) return;

        (int X, int Y) maelCoord;

        int[] affectedX;
        int[] affectedY;

        foreach(Maelstron m in maelsArray){

            maelCoord = m.getCoord();

            affectedX = affectedCoordinates(maelCoord.X);
            affectedY = affectedCoordinates(maelCoord.Y);

            foreach(Room r in this.gameMap){

                if(affectedX.Contains(r.roomCord.X)){
                    if(affectedY.Contains(r.roomCord.Y)){
                        r.underEffect = true;
                        continue;
                    }
                }

                r.underEffect = false;
            }
        }
    }

    private int[] affectedCoordinates(int coord){

        int[] affectedCoord = new int[3];
        int k = 0;

        for(int i = (coord - 1); i <= (coord + 1); i++){

            affectedCoord[k] = i;
            k++;

        }

        return affectedCoord;

    }
}