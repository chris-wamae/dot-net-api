namespace DotnetApi.Models
{
    class Platforms
    {

        //belongs to a ProPlayer
        //has many Games

        public int Id { get; set; }

        public int Name { get; set; }

        public int ReleaseDate { get; set; }

    }

}