using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tattoo_Shop.Data.Repository;
using Tattoo_Shop.Data.UnitOfWork;
using Tattoo_Shop.Models;

namespace Tattoo_Shop.Controllers
{
    public class OrderController : Controller
    {
        
        private readonly IUnitOfWork _uow;
        private readonly IOrderRepository _orderRepository;

        public OrderController(IUnitOfWork uow) { _uow = uow; }

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        //gaat een order ophalen op id
        [HttpGet]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            Order order = await _uow.OrderRepository.GetById(id);

            if (order == null) return NotFound();

            return View(order);
        }
        //gaat een lijst tonen van orders
        public async Task<ActionResult<IEnumerable<Order>>> Index()
        {
            var order = await _uow.OrderRepository.GetAll().ToListAsync();

            return View(order);
        }
        //gaat een order updaten
        [HttpPost]
        public async Task<IActionResult> EditOrder(int id, Order order)
        {
            if (id != order.Id) return BadRequest();

            _uow.OrderRepository.Update(order);
            await _uow.Save();

            return RedirectToAction("Index");
        }

        public ActionResult AddOrder()
        {
            return View();
        }

        //gaat een order toevoegen
        [HttpPost]
        public async Task<ActionResult<Order>> AddOrder(Order order)
        {
            _uow.OrderRepository.Create(order);
            await _uow.Save();

            return RedirectToAction("Index");
        }
        //gaat een order verwijderen
        [HttpGet]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            Order order = await _uow.OrderRepository.GetById(id);
            if (order == null) return NotFound();

            _uow.OrderRepository.Delete(order);
            await _uow.Save();

            return RedirectToAction("Index");
        }


    }
}
