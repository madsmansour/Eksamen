using System;
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
                    Id = 1,
                    Name = "HJC C70",
                    Price = 899,
                    Category = "Helmet",
                    Description = "En god hjelm til billige penge",
                    ProductImageId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "AGV X3000",
                    Price = 4679,
                    Category = "Helmet",
                    Description = "AGV X3000 lader dig drømme tilbage til gamle dage, da Giacomo Agostini tordnede mod sine 15 verdensmesterskabstitler!",
                    ProductImageId = 2
                },
                new Product()
                {
                    Id = 3,
                    Name = "MC-Sko XPD X-Zero R, Hvid",
                    Price = 699,
                    Category = "Boots",
                    Description = "Den ultimative sko til racekørere på hurtige og sjove ture.",
                    ProductImageId = 3
                },
                    new Product()
                {
                    Id = 4,
                    Name = "MC-Støvler Course Aero, Sort",
                    Price = 1149,
                    Category = "Boots",
                    Description = "Course Aero er sportsstøvler, der tilbyder stil, komfort og høj sikkerhed!",
                    ProductImageId = 4
                },
                new Product()
                {
                    Id = 5,
                    Name = "Handsker Course Alpha, Hvid",
                    Price = 339,
                    Category = "Gloves",
                    Description = "Fremstillet af blødt og smidigt læder, der giver handsken en stor fleksibilitet og slidstyrke",
                    ProductImageId = 5
                },
                new Product()
                {
                Id = 6,
                Name = "MC-Handsker Course Wasteland, Sort",
                Price = 139,
                Category = "Gloves",
                Description = "God streethandske med det helt rigtige retro urbanlook.",
                ProductImageId = 6
                },
                new Product()
                {
                    Id = 7,
                    Name = "Læderdragt 2-delt IXS Camaro 1",
                    Price = 3149,
                    Category = "Suits",
                    Description = "Stilet, robust og slidstærkt lædertøj med utrolig god ventilation. IXS har lykkes rigtig godt når de fremstillede Camaro-lædertøjet!",
                    ProductImageId = 7
                },
                new Product()
                {
                    Id = 8,
                    Name = "Læderdragt IXS Sport RS-1000",
                    Price = 11199,
                    Category = "Suits",
                    Description = "IXS RS-1000 er en læderdragt lavet af kængurulæder, for dig, der kræver den højest mulige sikkerhed og komfort!",
                    ProductImageId = 8
                });
            #endregion
           
            #region ImageSeed 
            modelBuilder.Entity<Image>().HasData(
                new Image()
                {
                Id = 1,
                Path = "/images/products/helmets/hjelm1.jpg"

                },
                new Image()
                {
                Id = 2,
                Path = "/images/products/helmets/hjelm2.jpg"
                },
                new Image()
                {
                Id = 3,
                Path = "/images/products/helmets/hjelm3.jpg"


                },
                new Image()
                {
                Id = 4,
                Path = "/images/products/helmets/AGV X3000 1.jpg"

                },

                new Image()
                {
                Id = 5,
                Path = "/images/products/helmets/AGV X3000 2.jpg"

                },

                new Image()
                {
                Id = 6,
                Path = "/images/products/helmets/AGV X3000 2.jpg"

                },
                new Image()
                {
                Id = 7,
                Path = "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 1.jpg"

                },
                new Image()
                {
                Id = 8,
                Path = "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 2.jpg"
                },
                new Image()
                {
                Id = 9,
                Path = "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 3.jpg"


                },
                new Image()
                {
                Id = 10,
                Path = "/images/products/boots/MC-Støvler Course Aero, Sort 1.jpg"

                },

                new Image()
                {
                Id = 11,
                Path = "/images/products/boots/MC-Støvler Course Aero, Sort 2.jpg"

                },

                new Image()
                {
                Id = 12,
                Path = "/images/products/boots/MC-Støvler Course Aero, Sort 3.jpg"

                },
                new Image()
                {
                Id = 13,
                Path = "/images/products/gloves/Handsker Course Alpha, Hvid 1.jpg"

                },
                new Image()
                {
                Id = 14,
                Path = "/images/products/gloves/Handsker Course Alpha, Hvid 2.jpg"
                },
                new Image()
                {
                Id = 15,
                Path = "/images/products/gloves/Handsker Course Alpha, Hvid 3.jpg"


                },
                new Image()
                {
                Id = 16,
                Path = "/images/products/gloves/MC-Handsker Course Wasteland, Sort 1.jpg"

                },

                new Image()
                {
                Id = 17,
                Path = "/images/products/gloves/MC-Handsker Course Wasteland, Sort 2.jpg"

                },

                new Image()
                {
                Id = 18,
                Path = "/images/products/gloves/MC-Handsker Course Wasteland, Sort 3.jpg"

                },
                new Image()
                {
                Id = 19,
                Path = "/images/products/suits/Læderdragt 2-delt IXS Camaro 1.jpg"

                },
                new Image()
                {
                Id = 20,
                Path = "/images/products/suits/Læderdragt 2-delt IXS Camaro 2.jpg"
                },
                new Image()
                {
                Id = 21,
                Path = "/images/products/suits/Læderdragt 2-delt IXS Camaro 3.jpg"


                },
                new Image()
                {
                Id = 22,
                Path = "/images/products/suits/Læderdragt IXS Sport RS-1000 1.jpg"

                },

                new Image()
                {
                Id = 23,
                Path = "/images/products/suits/Læderdragt IXS Sport RS-1000 2.jpg"

                },

                new Image()
                {
                Id = 24,
                Path = "/images/products/suits/Læderdragt IXS Sport RS-1000 3.jpg"

                },

                new Image()
                {
                    Id = 25,
                    Path = "/images/products/test/MC-Rygsæk XLMOTO Slipstream Vandresistent.jpg"

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

                },
                new ProductImage()
                {
                Id = 7,
                ProductId = 3,
                ImageId = 7

                },
                new ProductImage()
                {
                Id = 8,
                ProductId = 3,
                ImageId = 8

                },
                new ProductImage()
                {
                Id = 9,
                ProductId = 3,
                ImageId = 9

                },
                new ProductImage()
                {
                Id = 10,
                ProductId = 4,
                ImageId = 10

                },
                new ProductImage()
                {
                Id = 11,
                ProductId = 4,
                ImageId = 11

                },
                new ProductImage()
                {
                Id = 12,
                ProductId = 4,
                ImageId = 12

                },
                new ProductImage()
                {
                Id = 13,
                ProductId = 5,
                ImageId = 13

                },
                new ProductImage()
                {
                Id = 14,
                ProductId = 5,
                ImageId = 14

                },
                new ProductImage()
                {
                Id = 15,
                ProductId = 5,
                ImageId = 15

                },
                new ProductImage()
                {
                Id = 16,
                ProductId = 6,
                ImageId = 16

                },
                new ProductImage()
                {
                Id = 17,
                ProductId = 6,
                ImageId = 17

                },
                new ProductImage()
                {
                Id = 18,
                ProductId = 6,
                ImageId = 18

                },
                new ProductImage()
                {
                Id = 19,
                ProductId = 7,
                ImageId = 19

                },
                new ProductImage()
                {
                Id = 20,
                ProductId = 7,
                ImageId = 20

                },
                new ProductImage()
                {
                Id = 21,
                ProductId = 7,
                ImageId = 21

                },
                new ProductImage()
                {
                    Id = 22,
                    ProductId = 8,
                    ImageId = 22

                },
                new ProductImage()
                {
                    Id = 23,
                    ProductId = 8,
                    ImageId = 23

                },
                new ProductImage()
                {
                    Id = 24,
                    ProductId = 8,
                    ImageId = 24
                },
                new ProductImage()
                {
                    Id = 1016,
                    ProductId = 1016,
                    ImageId = 25
                }

            );
            #endregion

        }
    }


}
