﻿// <auto-generated />
using System;
using Clover_Store.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clover_Store.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240609104713_seedTables2")]
    partial class seedTables2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Clover_Store.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Card_CVC")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Card_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Card_number")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<DateTime>("EXdate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("Clover_Store.Models.Categorys", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "",
                            Name = "pants"
                        },
                        new
                        {
                            Id = 2,
                            Details = "",
                            Name = "sport"
                        },
                        new
                        {
                            Id = 3,
                            Details = "",
                            Name = "dress"
                        },
                        new
                        {
                            Id = 4,
                            Details = "",
                            Name = "skirt"
                        },
                        new
                        {
                            Id = 5,
                            Details = "",
                            Name = "shirt"
                        },
                        new
                        {
                            Id = 6,
                            Details = "",
                            Name = "sweat"
                        },
                        new
                        {
                            Id = 7,
                            Details = "",
                            Name = "Tunic"
                        },
                        new
                        {
                            Id = 8,
                            Details = "",
                            Name = "Coat"
                        });
                });

            modelBuilder.Entity("Clover_Store.Models.Colors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Blue")
                        .HasColumnType("int");

                    b.Property<int>("Green")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Red")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Blue = 54,
                            Green = 67,
                            Name = "Green",
                            Red = 37
                        },
                        new
                        {
                            Id = 2,
                            Blue = 142,
                            Green = 193,
                            Name = "Sage",
                            Red = 181
                        },
                        new
                        {
                            Id = 3,
                            Blue = 163,
                            Green = 183,
                            Name = "Brown",
                            Red = 199
                        },
                        new
                        {
                            Id = 4,
                            Blue = 58,
                            Green = 29,
                            Name = "Maroon",
                            Red = 169
                        },
                        new
                        {
                            Id = 5,
                            Blue = 124,
                            Green = 169,
                            Name = "Ecru",
                            Red = 185
                        },
                        new
                        {
                            Id = 6,
                            Blue = 65,
                            Green = 86,
                            Name = "Khaki",
                            Red = 91
                        });
                });

            modelBuilder.Entity("Clover_Store.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Full_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Log_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Phon_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Clover_Store.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Image_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("attributId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("attributId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Clover_Store.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CardID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_date")
                        .HasColumnType("Date");

                    b.Property<decimal>("Total_price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Zip_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CardID");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Clover_Store.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AttrbuteID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AttrbuteID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Clover_Store.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Material")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total_quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand_name = "LCW",
                            CategoryID = 1,
                            Description = "Made from waffle fabric, this t-shirt offers a stylish and modern look with its polo collar design.\r\n With its soft and comfortable texture,\r\n it can be preferred both in daily life and on special occasions.",
                            Material = "100% Cotton",
                            Title = "Polo Yaka Kısa Kollu Pike Erkek Tişört",
                            Total_quantity = 13,
                            Type = "Male"
                        },
                        new
                        {
                            Id = 2,
                            Brand_name = "adidas",
                            CategoryID = 5,
                            Description = "It is made of durable and easy-care polyester fabric.\r\n Its short sleeve design keeps you cool and comfortable even in hot weather conditions.",
                            Material = "100% Cotton",
                            Title = "Regular Fit Men's Short Sleeve Shirt",
                            Total_quantity = 13,
                            Type = "Male"
                        },
                        new
                        {
                            Id = 3,
                            Brand_name = "ZARA",
                            CategoryID = 7,
                            Description = "Round neck, straight short sleeve oversize tunic, made of single jersey fabric. It provides coolness in summer with its light and breathable structure.",
                            Material = "100% Cotton",
                            Title = "Crew Neck Plain Short Sleeve Oversize Women's Tunic",
                            Total_quantity = 13,
                            Type = "Male"
                        });
                });

            modelBuilder.Entity("Clover_Store.Models.Reviwe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CusomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("Date");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CusomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("Reviwe");
                });

            modelBuilder.Entity("Clover_Store.Models.Sizes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "",
                            Name = "XS"
                        },
                        new
                        {
                            Id = 2,
                            Details = "",
                            Name = "S"
                        },
                        new
                        {
                            Id = 3,
                            Details = "",
                            Name = "M"
                        },
                        new
                        {
                            Id = 4,
                            Details = "",
                            Name = "L"
                        },
                        new
                        {
                            Id = 5,
                            Details = "",
                            Name = "XL"
                        },
                        new
                        {
                            Id = 6,
                            Details = "",
                            Name = "2XL"
                        },
                        new
                        {
                            Id = 7,
                            Details = "",
                            Name = "3XL"
                        },
                        new
                        {
                            Id = 8,
                            Details = "",
                            Name = "26"
                        },
                        new
                        {
                            Id = 9,
                            Details = "",
                            Name = "27"
                        },
                        new
                        {
                            Id = 10,
                            Details = "",
                            Name = "28"
                        },
                        new
                        {
                            Id = 11,
                            Details = "",
                            Name = "29"
                        },
                        new
                        {
                            Id = 12,
                            Details = "",
                            Name = "30"
                        },
                        new
                        {
                            Id = 13,
                            Details = "",
                            Name = "30-31"
                        },
                        new
                        {
                            Id = 14,
                            Details = "",
                            Name = "30-32"
                        },
                        new
                        {
                            Id = 15,
                            Details = "",
                            Name = "31"
                        },
                        new
                        {
                            Id = 16,
                            Details = "",
                            Name = "32"
                        },
                        new
                        {
                            Id = 17,
                            Details = "",
                            Name = "32-31"
                        },
                        new
                        {
                            Id = 18,
                            Details = "",
                            Name = "36"
                        });
                });

            modelBuilder.Entity("Clover_Store.Models.attributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ColorID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorID");

                    b.HasIndex("ProductID");

                    b.HasIndex("SizeID");

                    b.ToTable("attributes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorID = 2,
                            Price = 699.99m,
                            ProductID = 1,
                            Quantity = 10,
                            SizeID = 2
                        },
                        new
                        {
                            Id = 2,
                            ColorID = 4,
                            Price = 699.99m,
                            ProductID = 1,
                            Quantity = 10,
                            SizeID = 3
                        },
                        new
                        {
                            Id = 3,
                            ColorID = 4,
                            Price = 799.99m,
                            ProductID = 1,
                            Quantity = 10,
                            SizeID = 4
                        },
                        new
                        {
                            Id = 4,
                            ColorID = 2,
                            Price = 675.00m,
                            ProductID = 2,
                            Quantity = 10,
                            SizeID = 3
                        },
                        new
                        {
                            Id = 5,
                            ColorID = 2,
                            Price = 975.00m,
                            ProductID = 2,
                            Quantity = 8,
                            SizeID = 6
                        },
                        new
                        {
                            Id = 6,
                            ColorID = 6,
                            Price = 975.00m,
                            ProductID = 2,
                            Quantity = 14,
                            SizeID = 3
                        },
                        new
                        {
                            Id = 7,
                            ColorID = 6,
                            Price = 899.99m,
                            ProductID = 2,
                            Quantity = 10,
                            SizeID = 5
                        },
                        new
                        {
                            Id = 8,
                            ColorID = 2,
                            Price = 899.99m,
                            ProductID = 3,
                            Quantity = 15,
                            SizeID = 2
                        });
                });

            modelBuilder.Entity("Clover_Store.Models.wishList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ProductID");

                    b.ToTable("wishList");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Clover_Store.Models.CustomerUsers", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Full_name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_url")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CustomerUsers");
                });

            modelBuilder.Entity("Clover_Store.Models.Image", b =>
                {
                    b.HasOne("Clover_Store.Models.attributes", "attributes")
                        .WithMany("Images")
                        .HasForeignKey("attributId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("attributes");
                });

            modelBuilder.Entity("Clover_Store.Models.Order", b =>
                {
                    b.HasOne("Clover_Store.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clover_Store.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Clover_Store.Models.OrderItem", b =>
                {
                    b.HasOne("Clover_Store.Models.attributes", "attribute")
                        .WithMany()
                        .HasForeignKey("AttrbuteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clover_Store.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("attribute");
                });

            modelBuilder.Entity("Clover_Store.Models.Product", b =>
                {
                    b.HasOne("Clover_Store.Models.Categorys", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Clover_Store.Models.Reviwe", b =>
                {
                    b.HasOne("Clover_Store.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CusomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clover_Store.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Clover_Store.Models.attributes", b =>
                {
                    b.HasOne("Clover_Store.Models.Colors", "Color")
                        .WithMany()
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clover_Store.Models.Product", "Product")
                        .WithMany("attributes")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clover_Store.Models.Sizes", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("Clover_Store.Models.wishList", b =>
                {
                    b.HasOne("Clover_Store.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Clover_Store.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Clover_Store.Models.Product", b =>
                {
                    b.Navigation("attributes");
                });

            modelBuilder.Entity("Clover_Store.Models.attributes", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
