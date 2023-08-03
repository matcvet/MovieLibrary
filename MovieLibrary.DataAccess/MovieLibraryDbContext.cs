using Microsoft.EntityFrameworkCore;
using MovieLibrary.DataAccess.Entities;

namespace MovieLibrary.DataAccess
{
    //Microsoft.EntityFrameworkCore
    //Microsoft.EntityFrameworkCore.Abstractions
    //Microsoft.EntityFrameworkCore.Design
    //Microsoft.EntityFrameworkCore.Relational
    //Microsoft.EntityFrameworkCore.SqlServer
    //Microsoft.EntityFrameworkCore.Tools
    public class MovieLibraryDbContext : DbContext
    {
        public MovieLibraryDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Movie> Movies { get; set; }
    }
}
