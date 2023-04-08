public class Enemy{

    protected (int X, int Y) enemyCoord;

    public Enemy((int, int) enemyCoord){
        this.enemyCoord = enemyCoord;
    }

    public (int, int) getCoord(){
        return this.enemyCoord;
    }

    public virtual void updateEnemyCoord(int mapSize){

    }


}


public class Maelstron:Enemy{

    public Maelstron((int, int) coord) : base (coord){
        this.enemyCoord = coord;
    }

    public override void updateEnemyCoord(int mapSize)
    {

        (int X, int Y) newCoord = this.enemyCoord;
        newCoord.X -= 2;
        newCoord.Y -= 1;

        if(newCoord.X < 0) newCoord.X = mapSize - 1;
        if(newCoord.X > (mapSize - 1)) newCoord.X = 0;

        if(newCoord.Y < 0) newCoord.X = mapSize - 1;
        if(newCoord.Y > (mapSize - 1)) newCoord.X = 0;

        this.enemyCoord = newCoord;

    }

    public (int, int) affectPlayer((int, int) plCoord, int mapSize){

        plCoord.Item1 = plCoord.Item1 + 1;
        plCoord.Item2 = plCoord.Item2 + 2;

        if(plCoord.Item1 < 0) plCoord.Item1 = mapSize - 1;
        if(plCoord.Item1 > (mapSize - 1)) plCoord.Item1 = 0;

        if(plCoord.Item2 < 0) plCoord.Item2 = mapSize - 1;
        if(plCoord.Item2 > (mapSize - 1)) plCoord.Item2 = 0;

        return plCoord;

    }

}