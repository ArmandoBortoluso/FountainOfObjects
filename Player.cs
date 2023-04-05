public class Player{

    private (int X, int Y) playerCoord;
    private int mapSize;

    private int step;

    private bool winCondition = false;
    
    public Player(int mapSize){
        this.playerCoord = (0,0);
        this.mapSize = mapSize;
    }

    public bool playerAction(Action action, (int X, int Y) fountainCoordinate){

        switch(action){

            case Action.MOVE_NORTH:
            step = this.playerCoord.Y + 1;
            if(validateStep(step)){
                this.playerCoord.Y += 1;
            }
            break;

            case Action.MOVE_SOUTH:
            step = this.playerCoord.Y - 1;
            if(validateStep(step)){
                this.playerCoord.Y -= 1;
            }
            break;

            case Action.MOVE_EAST:
            step = this.playerCoord.X + 1;
            if(validateStep(step)){
                this.playerCoord.X += 1;
            }
            break;

            case Action.MOVE_WEST:
            step = this.playerCoord.X - 1;
            if(validateStep(step)){
                this.playerCoord.X -= 1;
            }
            break;

            case Action.ENABLE:
            enableAction(fountainCoordinate);
            break;

            case Action.DISABLE:
            break;           
        }

        return this.winCondition;
    }


    private bool validateStep(int step){

        if(step < this.mapSize && step >= 0){
            return true;
        } else {
            Console.WriteLine("Sorry, there is a wall stopping you!");
            return false;
        }

    }

    private void enableAction((int X, int Y)fountainCoordinate){

        if(this.playerCoord == fountainCoordinate){
            this.winCondition = true;
        } else{
            Console.WriteLine("Activate what?");
        }

    }

    public (int, int) getPlayerCoord(){
        return this.playerCoord;
    }


}