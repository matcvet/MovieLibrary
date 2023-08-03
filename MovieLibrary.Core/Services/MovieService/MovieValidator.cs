using MovieLibrary.Core.Models;
using FluentValidation;

namespace MovieLibrary.Core.Services
{
    public class MovieValidator : AbstractValidator<MovieModel>
    {
        public MovieValidator()
        {
            RuleFor(movie => movie.Title).NotEmpty().NotNull().WithMessage("Movie title is required!");
            RuleFor(movie => movie.Description).NotEmpty().NotNull().WithMessage("Movie description is required!");
        }
    }
}
