using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetRecord()
        {
            return Ok("Hello Admin Portal");
        }
    }
}
