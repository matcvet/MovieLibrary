using MovieLibrary.DataAccess.Abstraction;
using MovieLibrary.DataModels;
using MovieLibrary.ServiceModels.Models;
using MovieLibrary.Services.Abstraction;
using MovieLibrary.Mappers;

namespace MovieLibrary.Services.Implementation
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<MovieDto> _movieRepository;

        public MovieService(IRepository<MovieDto> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(MovieModel model)
        {
            _movieRepository.Add(model.ToMovieDto());
        }

        public void DeleteMovie(int id)
        {
            _movieRepository.Delete(_movieRepository.GetById(id));
        }

        public List<MovieModel> GetAllMovies()
        {
            return _movieRepository.GetAll().Select(movie => movie.ToMovieModel()).ToList();
        }

        public MovieModel GetMovieById(int id)
        {
            return _movieRepository.GetById(id).ToMovieModel();
        }

        public void UpdateMovie(MovieModel model)
        {
            var movieToUpdate = _movieRepository.GetById(model.Id);

            movieToUpdate.Title = model.Title;
            movieToUpdate.Description = model.Description;
            movieToUpdate.Year = model.Year;
            movieToUpdate.Genre = (int)model.Genre;

            _movieRepository.Update(movieToUpdate);
        }
    }
}
