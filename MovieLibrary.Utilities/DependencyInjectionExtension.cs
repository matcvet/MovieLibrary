using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieLibrary.DataAccess;
using MovieLibrary.DataAccess.Abstraction;
using MovieLibrary.DataAccess.Repositories;
using MovieLibrary.DataAccess.Entities;
using MovieLibrary.Core.Services;

namespace MovieLibrary.Utilities
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterModule(this IServiceCollection services, string? connectionString)
        {
            // Connection String
            services.AddDbContext<MovieLibraryDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            // Repositories
            services.AddTransient<IRepository<Movie>, MovieRepository>();

            // Services
            services.AddTransient<IMovieService, MovieService>();

            return services;
        }
    }
}
