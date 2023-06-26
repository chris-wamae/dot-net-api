namespace DotnetApi.Models{

public class Studio {

    //has many games
    public int Id {get;set;}

    public int Name {get;set;}

    public int Location {get;set;}

    public ICollection<Game> Games {get;set;}

}

}

