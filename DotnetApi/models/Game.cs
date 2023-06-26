 namespace DotnetApi.Models{
public class Game {
   //belongs to a Studio
   //has many ProPlayers
   //has many Platforms 

   public int Id {get; set;}

   public string Title {get;set;}

   public DateTime ReleaseDate {get;set;}

   public Studio Studio  {get;set;}

   public ICollection<ProPlayer> ProPlayers {get;set;}

   }

}
