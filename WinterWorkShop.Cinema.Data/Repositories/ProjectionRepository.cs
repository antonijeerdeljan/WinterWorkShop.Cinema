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
                    var projectionModel = new ProjectionModel();
                    projectionModel.Id = projection.Id;
                    projectionModel.Name = projection.Name;
                    projectionModel.Description = projection.Description;
                    projectionModel.DateTime = projection.DateTime;
                    projectionModel.BrojSale = projection.BrojSale;
                    return projectionModel;
                }
            }
            return null;
        }
    }
}