﻿// <auto-generated />
using Eksamen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eksamen.Migrations
{
    [DbContext(typeof(WebshopContext))]
    [Migration("20200522092617_All products added")]
    partial class Allproductsadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Eksamen.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Path = "/images/products/helmets/hjelm1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Path = "/images/products/helmets/hjelm2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Path = "/images/products/helmets/hjelm3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Path = "/images/products/helmets/AGV X3000 1.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Path = "/images/products/helmets/AGV X3000 2.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Path = "/images/products/helmets/AGV X3000 2.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Path = "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 1.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Path = "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 2.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Path = "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 3.jpg"
                        },
                        new
                        {
                            Id = 10,
                            Path = "/images/products/boots/MC-Støvler Course Aero, Sort 1"
                        },
                        new
                        {
                            Id = 11,
                            Path = "/images/products/boots/MC-Støvler Course Aero, Sort 2"
                        },
                        new
                        {
                            Id = 12,
                            Path = "/images/products/boots/MC-Støvler Course Aero, Sort 3"
                        },
                        new
                        {
                            Id = 13,
                            Path = "/images/products/gloves/Handsker Course Alpha, Hvid 1.jpg"
                        },
                        new
                        {
                            Id = 14,
                            Path = "/images/products/gloves/Handsker Course Alpha, Hvid 2.jpg"
                        },
                        new
                        {
                            Id = 15,
                            Path = "/images/products/gloves/Handsker Course Alpha, Hvid 3.jpg"
                        },
                        new
                        {
                            Id = 16,
                            Path = "/images/products/gloves/MC-Handsker Course Wasteland, Sort 1"
                        },
                        new
                        {
                            Id = 17,
                            Path = "/images/products/gloves/MC-Handsker Course Wasteland, Sort 2"
                        },
                        new
                        {
                            Id = 18,
                            Path = "/images/products/gloves/MC-Handsker Course Wasteland, Sort 3"
                        },
                        new
                        {
                            Id = 19,
                            Path = "/images/products/suits/Læderdragt 2-delt IXS Camaro 1.jpg"
                        },
                        new
                        {
                            Id = 20,
                            Path = "/images/products/suits/Læderdragt 2-delt IXS Camaro 2.jpg"
                        },
                        new
                        {
                            Id = 21,
                            Path = "/images/products/suits/Læderdragt 2-delt IXS Camaro 3.jpg"
                        },
                        new
                        {
                            Id = 22,
                            Path = "/images/products/suits/Læderdragt IXS Sport RS-1000 1.jpg"
                        },
                        new
                        {
                            Id = 23,
                            Path = "/images/products/suits/Læderdragt IXS Sport RS-1000 2.jpg"
                        },
                        new
                        {
                            Id = 24,
                            Path = "/images/products/suits/Læderdragt IXS Sport RS-1000 3.jpg"
                        });
                });

            modelBuilder.Entity("Eksamen.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("Decimal(18,2)");

                    b.Property<int>("ProductImageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Helmet",
                            Description = "En god hjelm til billige penge",
                            Name = "HJC C70",
                            Price = 899m,
                            ProductImageId = 1
                        },
                        new
                        {
                            Id = 2,
                            Category = "Helmet",
                            Description = "AGV X3000 lader dig drømme tilbage til gamle dage, da Giacomo Agostini tordnede mod sine 15 verdensmesterskabstitler!",
                            Name = "AGV X3000",
                            Price = 4679m,
                            ProductImageId = 2
                        },
                        new
                        {
                            Id = 3,
                            Category = "Boots",
                            Description = "Den ultimative sko til racekørere på hurtige og sjove ture.",
                            Name = "MC-Sko XPD X-Zero R, Hvid",
                            Price = 699m,
                            ProductImageId = 3
                        },
                        new
                        {
                            Id = 4,
                            Category = "Boots",
                            Description = "Course Aero er sportsstøvler, der tilbyder stil, komfort og høj sikkerhed!",
                            Name = "MC-Støvler Course Aero, Sort",
                            Price = 1149m,
                            ProductImageId = 4
                        },
                        new
                        {
                            Id = 5,
                            Category = "Gloves",
                            Description = "Fremstillet af blødt og smidigt læder, der giver handsken en stor fleksibilitet og slidstyrke",
                            Name = "Handsker Course Alpha, Hvid",
                            Price = 339m,
                            ProductImageId = 5
                        },
                        new
                        {
                            Id = 6,
                            Category = "Gloves",
                            Description = "God streethandske med det helt rigtige retro urbanlook.",
                            Name = "MC-Handsker Course Wasteland, Sort",
                            Price = 139m,
                            ProductImageId = 6
                        },
                        new
                        {
                            Id = 7,
                            Category = "Suits",
                            Description = "Stilet, robust og slidstærkt lædertøj med utrolig god ventilation. IXS har lykkes rigtig godt når de fremstillede Camaro-lædertøjet!",
                            Name = "Læderdragt 2-delt IXS Camaro 1",
                            Price = 3149m,
                            ProductImageId = 7
                        },
                        new
                        {
                            Id = 8,
                            Category = "Suits",
                            Description = "IXS RS-1000 er en læderdragt lavet af kængurulæder, for dig, der kræver den højest mulige sikkerhed og komfort!",
                            Name = "Læderdragt IXS Sport RS-1000",
                            Price = 11199m,
                            ProductImageId = 8
                        });
                });

            modelBuilder.Entity("Eksamen.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ImageId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            ImageId = 3,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            ImageId = 4,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            ImageId = 5,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 6,
                            ImageId = 6,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 7,
                            ImageId = 7,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 8,
                            ImageId = 8,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 9,
                            ImageId = 9,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 10,
                            ImageId = 10,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 11,
                            ImageId = 11,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 12,
                            ImageId = 12,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 13,
                            ImageId = 13,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 14,
                            ImageId = 14,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 15,
                            ImageId = 15,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 16,
                            ImageId = 16,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 17,
                            ImageId = 17,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 18,
                            ImageId = 18,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 19,
                            ImageId = 19,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 20,
                            ImageId = 20,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 21,
                            ImageId = 21,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 22,
                            ImageId = 22,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 23,
                            ImageId = 23,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 24,
                            ImageId = 24,
                            ProductId = 8
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
