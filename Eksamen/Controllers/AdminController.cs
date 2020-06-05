using Microsoft.AspNetCore.Mvc;
using Eksamen.Models;


namespace Eksamen.Controllers
{

    public class AdminController : Controller
    {


        // 1. *************RETRIEVE ALL PRODUCT DETAILS ******************
        // GET: Admin/Select
        public ActionResult Select()
        {
            ProductHandle dbhandle = new ProductHandle();
            ModelState.Clear();
            return View(dbhandle.GetProducts());
        }

        // 2. *************ADD NEW PRODUCT ******************
        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ProductHandle sdb = new ProductHandle();
                    if (sdb.AddProduct(product))
                    {
                        ViewBag.Message = "Product Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // 3. ************* EDIT PRODUCT DETAILS ******************
        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            ProductHandle sdb = new ProductHandle();
            return View(sdb.GetProducts().Find(product => product.Id == id));
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                ProductHandle sdb = new ProductHandle();
                sdb.UpdateDetails(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // 4. ************* DELETE Product DETAILS ******************
        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                ProductHandle sdb = new ProductHandle();
                if (sdb.DeleteProduct(id))
                {
                    ViewBag.AlertMsg = "Product Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}