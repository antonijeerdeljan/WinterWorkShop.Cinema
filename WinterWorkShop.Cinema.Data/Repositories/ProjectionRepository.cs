using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionRepository : IProjectionRepository
    {
        public Database Database = new Database();

        public List<ProjectionModel> GetAll()
        {
            return Database.GetProjectionResponses;
        }

        public ProjectionModel GetById(int id) 
        {
            List<ProjectionModel> projectionModels = GetAll();

            foreach (var projection in projectionModels)
            {
                if (projection.Id == id)
                {
                    return projection;
                }
            }
            return null;
        }

        public List<ProjectionModel> GetByMovieId(int movieId)
        {
            List<ProjectionModel> projectionModels = GetAll();
            List<ProjectionModel> projectionModelsWithMovieId = new List<ProjectionModel>();
            foreach (var projection in projectionModels)
            {
                if(projection.MovieId == movieId)
                {
                    projectionModelsWithMovieId.Add(projection);
                }
            }
            
            return projectionModelsWithMovieId;

        }
    }
}