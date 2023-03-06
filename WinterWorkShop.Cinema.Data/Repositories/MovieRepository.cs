using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Database Database = new Database();

        public List<MovieModel> GetAllMovies()
        {
            return Database.GetAllMoviesResponses;
        }

        public MovieModel GetById(int id)
        {
            List<MovieModel> movieModels = GetAllMovies();
            foreach (var movie in movieModels)
            {
                if (movie.Id == id)
                {
                    return movie;
                }
            }
            return null;
        }
    }
}
