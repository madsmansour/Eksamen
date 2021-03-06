using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using Eksamen.Data;
using Eksamen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eksamen.Controllers
{
    public class ShopController : Microsoft.AspNetCore.Mvc.Controller
    {
        private WebshopContext db = new WebshopContext(new DbContextOptions<WebshopContext>());
        private readonly IConfiguration _configuration;

        public ShopController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: /<controller>/
        public IActionResult Shop()
        {
            string connectionString = _configuration.GetConnectionString("Webshop");
            string sql = " SELECT Products.Name, min(Images.Path) as 'image', Products.Category, Products.Price, Products.Description, Products.Id " +
                "FROM Products, ProductImages, Images where ProductImages.ImageId = Images.Id and ProductImages.ProductId = Products.Id " +
                "GROUP BY Products.Name, Products.Category, Products.Price, Products.Description, Products.Id"; //her bruger jeg join query (Fra 3 tables) til at indl�se det f�rste billede og data";
            var model = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var product = new Product();
                    product.Id = rdr.GetInt32(rdr.GetOrdinal("Id"));
                    product.Name = rdr.GetString(rdr.GetOrdinal("Name"));
                    product.Price = rdr.GetDecimal(rdr.GetOrdinal("Price"));
                    product.Description = rdr.GetString(rdr.GetOrdinal("Description"));
                    product.Category = rdr.GetString(rdr.GetOrdinal("Category"));
                    product.Image = rdr.GetString(rdr.GetOrdinal("Image"));
                    model.Add(product);
                }

            }

            return View(model);
        }
        public IActionResult ShoppingCart()
        {
            var product = new Product();
            product.Name = "Hjelm";
            var cart = new List<Product>();
            cart.Add(product);
            return View();
        }

    }
}

