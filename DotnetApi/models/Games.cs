 namespace DotnetApi.Models{
public class Games {
   //belongs to a Studio
   //has many ProPlayers
   //has many Platforms 

   public int Id {get; set;}

   public string Title {get;set;}

   public DateTime ReleaseDate {get;set;}

}

}
