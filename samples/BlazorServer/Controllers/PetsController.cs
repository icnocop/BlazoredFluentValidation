using BlazorServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] Pet pet)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            return this.Created("/api/Pets/1", pet);
        }
    }
}
