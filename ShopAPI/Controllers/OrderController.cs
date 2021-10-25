using Microsoft.AspNetCore.Mvc;

namespace ShopAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public OrderController()
        {

        }

        [HttpGet("{id}")]
        public void ShowOne<IActionResult>(int id)
        {

        }
    }
}
