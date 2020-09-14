using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace CoffeeShoppp.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public long id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }

        public static Product Create(string _name, string _description, Decimal _price)
        {
            //Create new instance
            Product prod = new Product() { Name = _name, Description = _description, Price = _price };

            //Save to DB
            IDbConnection db = new SqlConnection("Server=.;Database=devbuild1;user id=dbuser;password=abc123");
            long _id = db.Insert<Product>(prod);

            //Set id
            prod.id = _id;

            //Return instance
            return prod;
        }

        public static List<Product> List()
        {
            IDbConnection db = new SqlConnection("Server =.;Database=devbuild1;user id=dbuser;password=abc123");
            List<Product> productlist = db.Query<Product>("SELECT * FROM Product").AsList<Product>();
            return productlist;
        }

        public static Product Read(long _id)
        {
            IDbConnection db = new SqlConnection("Server=.;Database=devbuild1;user id=dbuser;password=abc123");
            Product prod = db.Get<Product>(_id);
            return prod;
        }

        public static Product Add()
        {
            IDbConnection db = new SqlConnection("Server =.;Database=devbuild1;user id=dbuser;password=abc123");
            return null;
        }

        public void Edit()
        {
            IDbConnection db = new SqlConnection("Server =.;Database=devbuild1;user id=dbuser;password=abc123");
            db.Update(this);
        }

        public static void Delete(long _id)
        {
            IDbConnection db = new SqlConnection("Server =.;Database=devbuild1;user id=dbuser;password=abc123");
            db.Delete(new Product() { id = _id });
        }
    }
}
