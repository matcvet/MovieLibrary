using MovieLibrary.Core.Enums;

namespace MovieLibrary.Core.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
    }
}
