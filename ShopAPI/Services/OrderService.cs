using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Entities;
using ShopAPI.Interfaces;
using ShopAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly ShopContext _context;
        private readonly IMapper _mapper;

        public OrderService(ShopContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<OrderDto> ShowAll()
        {
            var orders = _context
                .Orders
                .Include(x => x.Products)
                .Include(x => x.Addresses)
                .ToList();

            if (orders == null)
            {
                throw new ArgumentException("Bład");
            }

            var orderDto = _mapper.Map<IEnumerable<OrderDto>>(orders);

            return orderDto;
        }

        public OrderDto ShowById(int id)
        {

            var order = _context
                .Orders
                .Include(x => x.Products)
                .Include(x => x.Addresses)
                .FirstOrDefault(x => x.OrderId == id);

            if (order == null)
            {
                throw new ArgumentException("Bład");
            }

            var orderDto = _mapper.Map<OrderDto>(order);

            return orderDto;
         }
    }
}
