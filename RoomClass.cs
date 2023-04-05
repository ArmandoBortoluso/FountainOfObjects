public class Room{

    protected string description;

    public void showDescription(){

        Console.WriteLine(description);
    }

}


public class FountainRoom : Room{

    public bool Activated {get; private set;} = false;

    public FountainRoom(){

        this.description = "You hear the water dripping in this room. The Fountain of Objects is here!";
    }

    public void activeFountain(){

        this.description = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
        this.Activated = true;
    }

}

public class CaveEntreance:Room{

    public CaveEntreance(){
        this.description = "You see light in this room coming from outside the cavern. This is the entrance.";
    }
}

public class EmptyRoom:Room{

    public EmptyRoom(){
        this.description = "There is nothing to see, hear or smell here...";
    }
}