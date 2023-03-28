using Class09_20024.Models;
using System.Collections.Generic;

namespace Class09_20024.Data
{
    public class Context
    {
        public List<Movie> Movies { get; set; }
        public List<Show> Shows { get; set; }
        public List<Video> Videos { get; set; }

        public Context()
        {
            Movies = new List<Movie>();
            Movies.Add(new Movie() { Id = 1, Title = "Creed 3", Year = "2023" });
            Movies.Add(new Movie() { Id = 2, Title = "Dungeons & Dragons", Year = "2023" });
            Movies.Add(new Movie() { Id = 3, Title = "Avatar 2", Year = "2023" });
            Movies.Add(new Movie() { Id = 4, Title = "John Wick 4", Year = "2023" });

            Shows = new List<Show>();
            Shows.Add(new Show() { Id = 1, Title = "Supernatural", Year = "2023" });
            Shows.Add(new Show() { Id = 2, Title = "American Idol", Year = "2023" });
            Shows.Add(new Show() { Id = 3, Title = "Enamorandanos", Year = "2023" });
            Shows.Add(new Show() { Id = 4, Title = "The Voice", Year = "2023" });

            Videos = new List<Video>();
            Videos.Add(new Video() { Id = 1, Title = "My Little Pony", Year = "2023" });
            Videos.Add(new Video() { Id = 2, Title = "When Harry Met Sally", Year = "2023" });
            Videos.Add(new Video() { Id = 3, Title = "Ferris Buellers Day Off", Year = "2023" });
            Videos.Add(new Video() { Id = 4, Title = "Backyardigans", Year = "2023" });
        }
    }
}
