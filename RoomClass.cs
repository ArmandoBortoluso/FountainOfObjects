public class Room{

    protected string? description;
    public readonly (int X, int Y) roomCord;

    public bool underEffect = false;

    public Room((int, int) coord){
        this.roomCord = coord;
    }

    public void showDescription(){

        if(this.underEffect == false){
            Console.WriteLine(description);
        } else {
            Console.WriteLine("You hear the growling and groaning of a maelstrom nearby.");
        }

    }

}


public class FountainRoom : Room{

    public bool Activated {get; private set;} = false;

    public FountainRoom((int, int) coord) : base(coord){

        this.description = "You hear the water dripping in this room. The Fountain of Objects is here!";
    }

    public void activeFountain(){

        this.description = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
        this.Activated = true;
    }

}

public class CaveEntreance:Room{

    public CaveEntreance((int, int) coord) : base(coord){
        this.description = "You see light in this room coming from outside the cavern. This is the entrance.";
    }
}

public class EmptyRoom:Room{

    public EmptyRoom((int, int) coord) : base(coord){
        this.description = "There is nothing to see, hear or smell here...";
    }
}