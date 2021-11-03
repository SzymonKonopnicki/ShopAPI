using ShopAPI.Entities;
using ShopAPI.Model;
using System.Collections.Generic;

namespace ShopAPI.Interfaces
{
    public interface IOrderService
    {
        public OrderDto ShowById(int id);
        public IEnumerable<OrderDto> ShowAll();
        public void DeleteById(int id);
        public void CreateNewOrder(OrderCreateDto orderDto);
        public void PutOrder(UpdataOrderDto updataOrderDto, int id);
    }
}