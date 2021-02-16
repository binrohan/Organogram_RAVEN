using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organogram.API.Data;

namespace Organogram.API.Controllers
{
    public class SectionController
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
            public async Task<IActionResult> GetSections ()
            {
                return Ok();
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetSection (int id)
            {
                return Ok(id);
            }

            [HttpPost]
            public async Task<IActionResult> SetSection ()
            {
                return Ok();
            }

            [HttpPost("{id}")]
            public async Task<IActionResult> UpdateSection (int id)
            {
                return Ok(id);
            }
        }
    }
}