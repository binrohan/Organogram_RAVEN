using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organogram.API.Data;

namespace Organogram.API.Controllers
{
    public class ProductionUnitController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CompanyController : ControllerBase
        {
            private readonly IOrganogramRepository _repo;
            public CompanyController(IOrganogramRepository repo)
            {
                _repo = repo;
            }

            [HttpGet]
            public async Task<IActionResult> GetProductionUnits ()
            {
                return Ok();
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetProductionUnit (int id)
            {
                return Ok(id);
            }

            [HttpPost]
            public async Task<IActionResult> SetProductionUnit ()
            {
                return Ok();
            }

            [HttpPost("{id}")]
            public async Task<IActionResult> UpdateProductionUnit (int id)
            {
                return Ok(id);
            }
        }
    }
}