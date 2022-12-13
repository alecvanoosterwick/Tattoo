using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Data.Repository;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.Data.UnitOfWork
{
    interface IUnitOfWork
    {
        IGenericRepository<Order> OrderRepository { get; }
        Task Save();
    }
}
