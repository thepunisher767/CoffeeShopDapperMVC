using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShoppp.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CoffeeShoppp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            IDbConnection db = new SqlConnection("Server =.;Database=devbuild1;user id=dbuser;password=abc123");
            db.Open();
            List<Product> productlist = db.Query<Product>("SELECT * FROM Product").AsList<Product>();
            db.Close();
            return View(productlist);
        }
        public IActionResult Details(string name)
        {
            IDbConnection db = new SqlConnection("Server =.;Database=devbuild1;user id=dbuser;password=abc123");
            db.Open();
            Product item = db.QuerySingle<Product>($"SELECT * FROM Product WHERE Name='{name}'");
            db.Close();
            return View(item);
        }
    }
}
