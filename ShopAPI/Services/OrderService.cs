using Microsoft.EntityFrameworkCore;
using ShopAPI.Entities;
using ShopAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly ShopContext _context;

        public OrderService(ShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> ShowAll()
        {
            var orders = _context
                .Orders
                .ToList();

            return orders;
        }

        public Order ShowById(int id)
        {

            var order = _context
                .Orders
                .FirstOrDefault(x => x.OrderId == id);

            if (order == null)
            {
                throw new ArgumentException("Bład");
            }

            return order;

         }
    }
}
