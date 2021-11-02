using Microsoft.AspNetCore.Mvc;
using ShopAPI.Entities;
using ShopAPI.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace ShopAPI.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOne([FromRoute]int id)
        {
            var order = _orderService.ShowById(id);
            return Ok(order);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAll()
        {
            var order = _orderService.ShowAll();
            return Ok(order);
        }

    }
}
