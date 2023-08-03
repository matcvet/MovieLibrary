using MovieLibrary.DataAccess.Abstraction;
using MovieLibrary.DataAccess.Entities;
using MovieLibrary.Core.Models;
using FluentValidation;

namespace MovieLibrary.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly MovieValidator _movieValidator = new MovieValidator();

        public MovieService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(MovieModel model)
        {
            _movieValidator.ValidateAndThrow(model);
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
