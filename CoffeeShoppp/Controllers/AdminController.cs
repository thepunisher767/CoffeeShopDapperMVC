using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShoppp.Models;

namespace CoffeeShoppp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<Product> list = Product.List();
            return View(list);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string Name, string Description, Decimal Price)
        {
            Product prod = Product.Create(Name, Description, Price);
            return View("Details", prod);
        }
        [HttpGet]
        public IActionResult Edit(long _id)
        {
            Product prod = Product.Read(_id);
            return View(prod);
        }
        [HttpPost]
        public IActionResult Save(long _id, string Name, string Description, Decimal Price)
        {
            Product prod = Product.Read(_id);
            prod.Name = Name;
            prod.Description = Description;
            prod.Price = Price;
            prod.Edit();
            return View("Details", prod);
        }

        public IActionResult Delete(long _id)
        {
            Product.Delete(_id);
            List<Product> list = Product.List();
            return View("Index", list);
        }

        public IActionResult Details(long _id)
        {
            return View(_id);
        }
    }
}
