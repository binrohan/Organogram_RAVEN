using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organogram.API.Data;

namespace Organogram.API.Controllers
{
    public class DepartmentController
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
            public async Task<IActionResult> GetDepartments ()
            {
                return Ok();
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetDepartment (int id)
            {
                return Ok(id);
            }

            [HttpPost]
            public async Task<IActionResult> SetDepartment ()
            {
                return Ok();
            }

            [HttpPost("{id}")]
            public async Task<IActionResult> UpdateDepartment (int id)
            {
                return Ok(id);
            }
        }
    }
}