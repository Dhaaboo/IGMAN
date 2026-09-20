using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IGMAN.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                status = "online",
                service = "IGMAN.Api"
            });
        }
    }
}
