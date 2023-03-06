using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projections")]
    public class ProjectionController : ControllerBase
    {
        public readonly IProjectionRepository _projectionRepository;

        public ProjectionController(IProjectionRepository projectionRepository)
        {
            _projectionRepository = projectionRepository;
        }

        [HttpGet()]
        public List<GetAllProjectionsResponse> GetProjections()
        {
            var projctions = _projectionRepository.GetAll();

            var result = new List<GetAllProjectionsResponse>();

            foreach (var projection in projctions)
            {
                result.Add(new GetAllProjectionsResponse
                {
                    Id = projection.Id,
                    Name = projection.Name,
                    Descripton = projection.Description,
                    BrojSale = projection.BrojSale,
                    DateTime = projection.DateTime,
                    MovieId = projection.MovieId,

                });
            }

            return result;
        }

        
        [HttpPost()]
        public GetAllProjectionsResponse GetProjectionById(int id) 
        {
            var result = new GetAllProjectionsResponse();
            var projectionModel = _projectionRepository.GetById(id);
            if (projectionModel == null)
                return null;
            else
            {
                result.BrojSale = projectionModel.BrojSale;
                result.DateTime = projectionModel.DateTime;
                result.Name = projectionModel.Name;
                result.Descripton = projectionModel.Description;
                result.Id = projectionModel.Id;
                result.MovieId = projectionModel.MovieId;
                return result;
            }
            
        }
        
        [HttpPost()]
        [Route("projectionsByMovieId")]

        public List<GetAllProjectionsResponse> GetAllProjectionsByMovieId(int movieId) 
        {
            var projetionModels = _projectionRepository.GetByMovieId(movieId);

            var result = new List<GetAllProjectionsResponse>();

            foreach (var projection in projetionModels)
            {
                result.Add(new GetAllProjectionsResponse
                {
                    Id = projection.Id,
                    Name = projection.Name,
                    Descripton = projection.Description,
                    BrojSale = projection.BrojSale,
                    DateTime = projection.DateTime,
                    MovieId = projection.MovieId,

                });
            }

            return result;
        }
        

    }
}
