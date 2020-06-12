using Microsoft.AspNetCore.Mvc;
using Eksamen.Models;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using System;
using System.Text;

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
            if (TempData["shortMessage"] != null) {
                ViewBag.AlertMsg = TempData["shortMessage"].ToString();
            }

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
            StringBuilder errorMessages = new StringBuilder();
            if (ModelState.IsValid)
            {
                try {
                ProductHandle sdb = new ProductHandle();
                if (sdb.AddProduct(product))
                {
                    ViewBag.Message = "Product Details Added Successfully";
                    ModelState.Clear();
                }
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    Console.WriteLine(errorMessages.ToString());
                }
            }
            return View();
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
                    TempData["shortMessage"] = "The product has been deleted!";
                }
                
                return RedirectToAction("Select");
            }
            catch
            {
                return View();
            }
        }
    }
}