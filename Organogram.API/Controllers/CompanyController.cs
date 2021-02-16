using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organogram.API.Data;

namespace Organogram.API.Controllers
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
        public async Task<IActionResult> GetCompanies () {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany (int id) {
            return Ok(id);
        }

        [HttpPost]
        public async Task<IActionResult> SetCompany () {
            return Ok();
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateCompany (int id) {
            return Ok(id);
        }
    }
}