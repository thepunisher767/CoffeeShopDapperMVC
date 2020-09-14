using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShoppp.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace CoffeeShoppp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> list = Product.List();
            return View(list);
        }
        public IActionResult Details(long _id)
        {
            return View(_id);
        }
    }
}
