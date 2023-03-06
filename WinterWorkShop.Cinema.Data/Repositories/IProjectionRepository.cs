using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public interface IProjectionRepository
    {
        public List<ProjectionModel> GetAll();

        public ProjectionModel GetById(int id);
    }
}
