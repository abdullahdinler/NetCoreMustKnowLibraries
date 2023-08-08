using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProduct()
        {
            var product = new {Id = 1, Name = "Pencil", Price = 45};
            return Ok(product);
        }
    }
}
