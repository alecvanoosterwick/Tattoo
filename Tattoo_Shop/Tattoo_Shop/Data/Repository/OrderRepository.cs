using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Data.Repository;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.Data.UnitOfWork
{
    public class OrderRepository : IOrderRepository
    {
        private readonly TattooContext _context;

        public OrderRepository(TattooContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> All()
        {
            return _context.Orders.ToList();
        }

        public Order Find(int id)
        {
            return _context.Orders.Find(id);
        }

        public IQueryable<Order> Search()
        {
            return _context.Orders.AsQueryable();
        }

        Order IOrderRepository.Add(Order order)
        {
            return _context.Orders.Add(order).Entity;
        }
    }
}
