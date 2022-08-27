using MovieLibrary.ServiceModels.Models;

namespace MovieLibrary.Services.Abstraction
{
    public interface IMovieService
    {
        MovieModel GetMovieById(int id);
        List<MovieModel> GetAllMovies();
        void AddMovie(MovieModel model);
        void UpdateMovie(MovieModel model);
        void DeleteMovie(int id);
    }
}
