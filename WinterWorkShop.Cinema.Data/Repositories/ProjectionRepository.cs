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
    }
}