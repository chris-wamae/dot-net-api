namespace DotnetApi.Models{

public class ProPlayers{
    
   //belongs to a Platform
   //has many games

  public int Id {get;set;}

  public string Player_name {get;set;}

  public DateTime StartDate {get;set;}

}

}