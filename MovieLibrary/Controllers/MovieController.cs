using Microsoft.AspNetCore.Mvc;
using MovieLibrary.Core.Models;
using MovieLibrary.Core.Services;

namespace MovieLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAllMovies()
        {
            var movies = _movieService.GetAllMovies();

            return Ok(movies);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetMovieById([FromRoute] int id)
        {
            var movie = _movieService.GetMovieById(id);

            return Ok(movie);
        }

        [HttpPost("Add")]
        public IActionResult AddMovie([FromBody] MovieModel model)
        {
            try
            {
                _movieService.AddMovie(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteMovie([FromRoute] int id)
        {
            _movieService.DeleteMovie(id);

            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult UpdateMovie([FromBody] MovieModel model)
        {
            _movieService.UpdateMovie(model);

            return Ok();
        }
    }
}
