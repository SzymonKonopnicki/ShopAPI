using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShopAPI.Entities;
using ShopAPI.Interfaces;
using ShopAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using ShopAPI.Exceptions;

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

        public void CreateNewOrder(OrderCreateDto orderCreateDto)
        {
            var newOrder = _mapper.Map<Order>(orderCreateDto);
            newOrder.Quantity = newOrder.Products.Count;

            _context.Add(newOrder);

            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            var order = _context
                .Orders
                .Include(x => x.Products)
                .Include(x => x.Addresses)
                .FirstOrDefault(x => x.OrderId == id);

            if (order is null)
                throw new NotFoundException("Nie znaleziono.");

            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public void PutOrder(UpdataOrderDto updataOrderDto, int id)
        {
            var order = _context
                .Orders
                .Include(x => x.Products)
                .Include(x => x.Addresses)
                .FirstOrDefault(x => x.OrderId == id);

            if (order is null)
                throw new NotFoundException("Nie znaleziono.");

            order.Addresses.City = updataOrderDto.City;
            order.Addresses.Email = updataOrderDto.Email;
            order.Addresses.Street = updataOrderDto.Street;
            order.DateDelivery = updataOrderDto.DateDelivery;

            _context.SaveChanges();
            
        }

        public IEnumerable<OrderDto> ShowAll()
        {
            var orders = _context
                .Orders
                .Include(x => x.Products)
                .Include(x => x.Addresses)
                .ToList();

            if (orders is null)
                throw new NotFoundException("Lista jest pusta.");


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

            if (order is null)
                throw new NotFoundException("Nie znaleziono.");

            var orderDto = _mapper.Map<OrderDto>(order);

            return orderDto;
         }
    }
}
