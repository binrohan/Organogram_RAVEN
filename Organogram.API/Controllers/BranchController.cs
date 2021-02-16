using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organogram.API.Data;

namespace Organogram.API.Controllers
{
    public class BranchController
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
            public async Task<IActionResult> GetBranches ()
            {
                return Ok();
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetBranch (int id)
            {
                return Ok(id);
            }

            [HttpPost]
            public async Task<IActionResult> SetBranch ()
            {
                return Ok(); 
            }

            [HttpPost("{id}")]
            public async Task<IActionResult> UpdateBranch (int id)
            {
                return Ok(id);
            }
        }
    }
}