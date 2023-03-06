using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Domain.Common
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel> 
        { 
            new MovieModel { Id = 1, Name = "Spuderman" , Description = "desc"},
            new MovieModel { Id = 2, Name = "Spuderman 2", Description = "desc1"}
        };

        public List<ProjectionModel> GetProjectionResponses = new List<ProjectionModel>
        {
            new ProjectionModel { Id = 3, Name = "Spuderman", BrojSale = 1, DateTime = new DateTime() , Description = "film1"},
            new ProjectionModel { Id = 3, Name = "Spuderman", BrojSale = 1, DateTime = new DateTime() , Description = "film1"}
        };
    }
}
