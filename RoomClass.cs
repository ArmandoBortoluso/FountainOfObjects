public class Room{

    protected string description;

}


public class fountainRoom : Room{

    private bool activatedFountain;

    public fountainRoom(){

        this.description = "You hear the water dripping in this room. The Fountain of Objects is here!";
        this.activatedFountain = false;
    }

    public void activeFountain(){

        this.activatedFountain = true;
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