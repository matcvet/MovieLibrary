using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieLibrary.DataAccess;
using MovieLibrary.DataAccess.Abstraction;
using MovieLibrary.DataAccess.Repositories;
using MovieLibrary.DataModels;
using MovieLibrary.Services.Abstraction;
using MovieLibrary.Services.Implementation;

namespace MovieLibrary.Utilities
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterModule(this IServiceCollection services, string connectionString)
        {
            // Connection string for db
            services.AddDbContext<MovieLibraryDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            // Repositories
            services.AddTransient<IRepository<MovieDto>, MovieRepository>();

            // Services
            services.AddTransient<IMovieService, MovieService>();

            return services;
        }
    }
}
