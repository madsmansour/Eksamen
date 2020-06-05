using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Eksamen.Models
{
    public class ProductHandle
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = "Data Source=DESKTOP-IOQO0BN\\MADS;Initial Catalog=Webshop;Integrated Security=True";
            con = new SqlConnection(constring);
        }

        // **************** ADD NEW PRODUCT *********************
        public bool AddProduct(Product product)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AddNewProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;
        
            cmd.Parameters.AddWithValue("@Id", product.Id);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@ProductImageId", product.ProductImageId);
            cmd.Parameters.AddWithValue("@Image", product.Image);

        con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********** VIEW PRODUCT DETAILS ********************
        public List<Product> GetProducts()
        {
            connection();
            List<Product> productlist = new List<Product>();

            SqlCommand cmd = new SqlCommand("GetProducts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                productlist.Add(
                    new Product
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Price = Convert.ToInt32(dr["Price"]),
                        Category = Convert.ToString(dr["Category"]),
                        Description = Convert.ToString(dr["Description"]),
                        ProductImageId = Convert.ToInt32(dr["ProductImageId"]),
                        Image = Convert.ToString(dr["Image"])
                    });
            }
            return productlist;
        }

        // ***************** UPDATE PRODUCT DETAILS *********************
        public bool UpdateDetails(Product product)
        {
            connection();
            SqlCommand cmd = new SqlCommand("UpdateProductDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", product.Id);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Category", product.Category);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.Parameters.AddWithValue("@ProductImageId", product.ProductImageId);
            cmd.Parameters.AddWithValue("@Image", product.Image);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********************** DELETE PRODUCT DETAILS *******************
        public bool DeleteProduct(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("DeleteProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}