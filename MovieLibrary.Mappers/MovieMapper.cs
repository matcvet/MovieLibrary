using MovieLibrary.DataModels;
using MovieLibrary.ServiceModels.Enums;
using MovieLibrary.ServiceModels.Models;

namespace MovieLibrary.Mappers
{
    public static class MovieMapper
    {
        public static MovieDto ToMovieDto(this MovieModel model)
        {
            return new MovieDto
            {
                Title = model.Title,
                Description = model.Description,
                Year = model.Year,
                Genre = (int)model.Genre
            };
        }

        public static MovieModel ToMovieModel(this MovieDto model)
        {
            return new MovieModel
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Year = model.Year,
                Genre = (MovieGenre)model.Genre
            };
        }
    }
}
