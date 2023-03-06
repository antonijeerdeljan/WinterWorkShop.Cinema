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

                });
            }

            return result;
        }


    }
}
