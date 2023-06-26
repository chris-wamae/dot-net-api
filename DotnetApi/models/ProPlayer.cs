namespace DotnetApi.Models{

public class ProPlayer{
    
   //belongs to a Platform
   //has many games

  public int Id {get;set;}

  public string Player_name {get;set;}

  public DateTime StartDate {get;set;}
  
  public Game Game {get;set;}

  public Platform Platform {get;set;}
  

}

}