﻿// <auto-generated />
using Eksamen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Eksamen.Migrations
{
    [DbContext(typeof(WebshopContext))]
    partial class WebshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Path = "/images/products/hjelm1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Path = "/images/products/hjelm2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Path = "/images/products/hjelm3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Path = "/images/products/AGV X3000 1.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Path = "/images/products/AGV X3000 2.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Path = "/images/products/AGV X3000 2.jpg"
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
                            Id = -1,
                            Category = "Helmet",
                            Description = "En god hjelm til billige penge",
                            Name = "HJC C70",
                            Price = 899m,
                            ProductImageId = 1
                        },
                        new
                        {
                            Id = -2,
                            Category = "Helmet",
                            Description = "AGV X3000 lader dig drømme tilbage til gamle dage, da Giacomo Agostini tordnede mod sine 15 verdensmesterskabstitler!",
                            Name = "AGV X3000",
                            Price = 4679m,
                            ProductImageId = 2
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
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
