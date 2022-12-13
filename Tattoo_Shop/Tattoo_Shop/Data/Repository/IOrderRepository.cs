using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Data.UnitOfWork;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.Data.Repository
{
    public interface IOrderRepository
    {
        Order Add(Order order);
        Order Find(int id);
        IEnumerable<Order> All();
        IQueryable<Order> Search();
    }
}
