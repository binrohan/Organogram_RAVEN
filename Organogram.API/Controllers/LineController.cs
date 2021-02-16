using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organogram.API.Data;

namespace Organogram.API.Controllers
{
    public class LineController
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
            public async Task<IActionResult> GetLines ()
            {
                return Ok();
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetLine (int id)
            {
                return Ok(id);
            }

            [HttpPost]
            public async Task<IActionResult> SetLine ()
            {
                return Ok();
            }

            [HttpPost("{id}")]
            public async Task<IActionResult> UpdateLine (int id)
            {
                return Ok(id);
            }
        }
    }
}