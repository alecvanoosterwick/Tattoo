using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Data.Repository;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGenericRepository<Order> orderRepository;

        private readonly TattooContext _context;

        public UnitOfWork(TattooContext tattooContext)
        {
            _context = tattooContext;
        }

        public IGenericRepository<Order> OrderRepository
        {
            get
            {
                if(this.orderRepository == null)
                {
                    this.orderRepository = new GenericRepository<Order>(_context);
                }
                return orderRepository;
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
