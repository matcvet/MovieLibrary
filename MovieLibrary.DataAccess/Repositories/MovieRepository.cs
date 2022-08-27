using MovieLibrary.DataAccess.Abstraction;
using MovieLibrary.DataModels;

namespace MovieLibrary.DataAccess.Repositories
{
    public class MovieRepository : IRepository<MovieDto>
    {
        private readonly MovieLibraryDbContext _dbContext;

        public MovieRepository(MovieLibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(MovieDto Entity)
        {
            _dbContext.Movies.Add(Entity);
            _dbContext.SaveChanges();
        }

        public void Delete(MovieDto Entity)
        {
            _dbContext.Movies.Remove(Entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<MovieDto> GetAll()
        {
            return _dbContext.Movies;
        }

        public MovieDto GetById(int id)
        {
            return _dbContext.Movies.FirstOrDefault(movie => movie.Id == id);
        }

        public void Update(MovieDto Entity)
        {
            _dbContext.Movies.Update(Entity);
            _dbContext.SaveChanges();
        }
    }
}
