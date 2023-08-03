using MovieLibrary.DataAccess.Abstraction;
using MovieLibrary.DataAccess.Entities;

namespace MovieLibrary.DataAccess.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly MovieLibraryDbContext _dbContext;

        public MovieRepository(MovieLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Movie entity)
        {
            _dbContext.Movies.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Movie entity)
        {
            _dbContext.Movies.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _dbContext.Movies;
        }

        public Movie GetById(int id)
        {
            return _dbContext.Movies.FirstOrDefault(movie => movie.Id == id);
        }

        public void Update(Movie entity)
        {
            _dbContext.Movies.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
