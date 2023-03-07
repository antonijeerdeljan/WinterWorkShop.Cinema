using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MoviesController : BaseController
    {
        public readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet()]
        public List<GetAllMoviesResponse> GetMovies()
        {
            var movies = _movieRepository.GetAllMovies();

            var result = new List<GetAllMoviesResponse>();

            foreach(var movie in movies)
            {
                result.Add(new GetAllMoviesResponse
                {
                    Id = movie.Id,
                    Name = movie.Name,
                    Descripton = movie.Description
                });
            }

            return result;
        }

        [HttpGet()]
        public GetAllMoviesResponse GetMovieById(int id)
        {
            var result = new GetAllMoviesResponse();
            var movieModel = _movieRepository.GetById(id);
            if (movieModel == null)
                return null;
            else
            {
                result.Id = movieModel.Id;
                result.Name = movieModel.Name;
                result.Descripton = movieModel.Description;
                return result;
            }

        }
    }
}