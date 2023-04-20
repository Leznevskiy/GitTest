using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GitTest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GitTest.Controllers
{
    public class HomeController : Controller
    {
        public List<Provider> providers = new List<Provider>
        {
            new Provider(1,"Что-то"),
            new Provider(2,"С"),
            new Provider(3,"Чем-то")
        };

        public List<Order> Orders = new List<Order>();
        private void AddList()
        {
            Orders.Add(new Order()
            {
                Id = 1,
                Number = "Квас",
                Date = DateTime.Now,
                Orders1 = new List<Provider>()
                {
                    new Provider(1,"что-то"),
                }
            });

            Orders.Add(new Order()
            {
                Id = 2,
                Number = "Лимонад",
                Date = DateTime.Now,
                Orders1 = new List<Provider>()
                {
                    new Provider(2,"С"),
                }
            });

            Orders.Add(new Order()
            {
                Id = 3,
                Number = "Монитор",
                Date = DateTime.Now,
                Orders1 = new List<Provider>()
                {
                    new Provider(3,"Чем-то"),
                }
            });
        }
        public async Task<IActionResult> Index()
        {
            //AddList();
            return PartialView(Orders.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
             Orders.Add(new Order()
            {
                Id = order.Id,
                Number = order.Number,
                Date = order.Date,
                Orders1 = new List<Provider>()
                {
                    new Provider(1,"что-то"),
                }
            });
            return RedirectToAction("Index");
        }
    }
}
