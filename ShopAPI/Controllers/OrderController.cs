using Microsoft.AspNetCore.Mvc;
using ShopAPI.Entities;
using ShopAPI.Interfaces;
using ShopAPI.Model;
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
        public ActionResult<OrderDto> GetOne([FromRoute] int id)
        {
            var order = _orderService.ShowById(id);

            return Ok(order);
        }

        [HttpGet]
        public ActionResult<IEnumerable<OrderDto>> GetAll()
        {
            var order = _orderService.ShowAll();

            return Ok(order);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder([FromRoute] int id)
        {
            _orderService.DeleteById(id);
            return Ok("Akcja przebiegła pomyślnie");
        }

        [HttpPost]
        public ActionResult CreateOrder([FromBody] OrderCreateDto orderDto)
        {
            _orderService.CreateNewOrder(orderDto);

            return Ok(Created("Akcja przebiegła pomyślnie", null));
        }

        [HttpPut("{id}")]
        public ActionResult EditOrder([FromBody]UpdataOrderDto updataOrderDto, [FromRoute]int id)
        {
            _orderService.PutOrder(updataOrderDto, id);
            return Ok();
        }
    }
}
