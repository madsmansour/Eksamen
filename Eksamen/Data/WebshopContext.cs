﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eksamen.Models;
using Microsoft.EntityFrameworkCore;

namespace Eksamen.Data
{
    public class WebshopContext : DbContext
    {

        public WebshopContext(DbContextOptions<WebshopContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ProductSeed 
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = -1,
                    Name = "HJC C70",
                    Price = 899,
                    Category = "Helmet",
                    Description = "En god hjelm til billige penge",
                    ProductImageId = 1
                },
            new Product()
            {
                Id = -2,
                Name = "AGV X3000",
                Price = 4679,
                Category = "Helmet",
                Description = "AGV X3000 lader dig drømme tilbage til gamle dage, da Giacomo Agostini tordnede mod sine 15 verdensmesterskabstitler!",
                ProductImageId = 2
            });
            #endregion
           
            #region ImageSeed 
            modelBuilder.Entity<Image>().HasData(
                new Image()
                {
                    Id = 1,
                    Path = "/images/products/hjelm1.jpg"

                },
            new Image()
            {
                Id = 2,
                Path = "/images/products/hjelm2.jpg"
            },
                 new Image()
                 {
                     Id = 3,
                     Path = "/images/products/hjelm3.jpg"


                 },
                  new Image()
                  {
                      Id = 4,
                      Path = "/images/products/AGV X3000 1.jpg"

                  },

                   new Image()
                   {
                       Id = 5,
                       Path = "/images/products/AGV X3000 2.jpg"

                   },

                    new Image()
                    {
                        Id = 6,
                        Path = "/images/products/AGV X3000 2.jpg"

                    }
                 );
            #endregion

            #region ProductImageSeed 
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage()
                {
                    Id = 1,
                    ProductId = 1,
                    ImageId = 1

                },
            new ProductImage()
            {
                Id = 2,
                ProductId = 1,
                ImageId = 2
            },
             new ProductImage()
                            {
                Id = 3,
                ProductId = 1,
                ImageId = 3

            },
                new ProductImage()
                {
                    Id = 4,
                    ProductId = 2,
                    ImageId = 4

                },
                new ProductImage()
                {
                    Id = 5,
                    ProductId = 2,
                    ImageId = 5

                },
                new ProductImage()
                {
                    Id = 6,
                    ProductId = 2,
                    ImageId = 6

                }
            );
            #endregion

        }
    }

}
