using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eksamen.Data;
using Eksamen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eksamen.Controllers
{
    public class ShopController : Controller
    {
        private WebshopContext db = new WebshopContext(new DbContextOptions<WebshopContext>());

       
        // GET: /<controller>/
        public IActionResult Shop()
        {
            String connectionString = "Server=DESKTOP-IOQO0BN\\MADS;Database=Webshop;Trusted_Connection=True;MultipleActiveResultSets=True";
            String sql = " SELECT Products.Name, min(Images.Path) as image FROM Products, ProductImages, Images where ProductImages.ImageId = Images.Id and ProductImages.ProductId = Products.Id group by Products.Name;"; //her bruger jeg join query til at indlæse det første billede og data
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
    }
}

