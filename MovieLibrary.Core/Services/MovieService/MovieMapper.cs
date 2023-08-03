using MovieLibrary.Core.Models;
using MovieLibrary.DataAccess.Entities;
using MovieLibrary.Core.Enums;

namespace MovieLibrary.Core.Services
{
    public static class MovieMapper
    {
        public static Movie ToMovieDto(this MovieModel model)
        {
            return new Movie
            {
                Title = model.Title,
                Description = model.Description,
                Year = model.Year,
                Genre = (int)model.Genre
            };
        }

        public static MovieModel ToMovieModel(this Movie model)
        {
            return new MovieModel
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Year = model.Year,
                Genre = (Genre)model.Genre
            };
        }
    }
}
