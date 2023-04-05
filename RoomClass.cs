public class Room{

    protected string description;

    public void showDescription(){

        Console.WriteLine(description);
    }

}


public class fountainRoom : Room{

    public fountainRoom(){

        this.description = "You hear the water dripping in this room. The Fountain of Objects is here!";
    }

    public void activeFountain(){

        this.description = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!";
    }

}

public class caveEntreance:Room{

    public caveEntreance(){
        this.description = "You see light in this room coming from outside the cavern. This is the entrance.";
    }
}

public class emptyRoom:Room{

    public emptyRoom(){
        this.description = "There is nothing to see, hear or smell here...";
    }
}