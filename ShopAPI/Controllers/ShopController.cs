using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        public ShopController()
        {

        }

        [HttpGet("{id}")]
        public void ShowOne<IActionResult>(int id)
        {

        }
    }
}
