using ShopAPI.Entities;
using System.Collections.Generic;

namespace ShopAPI.Interfaces
{
    public interface IOrderService
    {
        public Order ShowById(int id);
        public IEnumerable<Order> ShowAll();
    }
}