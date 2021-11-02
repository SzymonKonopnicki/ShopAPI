using ShopAPI.Entities;
using ShopAPI.Model;
using System.Collections.Generic;

namespace ShopAPI.Interfaces
{
    public interface IOrderService
    {
        public OrderDto ShowById(int id);
        public IEnumerable<OrderDto> ShowAll();
    }
}