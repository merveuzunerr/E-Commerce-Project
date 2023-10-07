﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.Property<int>("CartsId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductsId")
                        .HasColumnType("integer");

                    b.HasKey("CartsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CartProduct");
                });

            modelBuilder.Entity("Core.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserAccountId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Beyaz Eşya",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Bilgisayar",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Küçük Ev Aletleri",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Telefon",
                            ParentCategoryId = 1
                        });
                });

            modelBuilder.Entity("Core.Models.ParentCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ParentCategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ParentCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ParentCategoryName = "Elektronik"
                        });
                });

            modelBuilder.Entity("Core.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "LG BUZDOLABI",
                            Price = 138999m,
                            Stock = 100,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "VESTEL BUZDOLABI",
                            Price = 16425m,
                            Stock = 80,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "SIEMENS BUZDOLABI",
                            Price = 37959m,
                            Stock = 70,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "SAMSUNG BUZDOLABI",
                            Price = 37989m,
                            Stock = 50,
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "LENOVA LEPTOP",
                            Price = 13899m,
                            Stock = 100,
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "HUAWEİ LEPTOP",
                            Price = 14425m,
                            Stock = 80,
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "APPLE LEPTOP",
                            Price = 38959m,
                            Stock = 70,
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "ASUS LEPTOP",
                            Price = 24000m,
                            Stock = 50,
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "VESTEL KETTLE",
                            Price = 1400m,
                            Stock = 100,
                            SubCategoryId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "ARZUM BLENDER",
                            Price = 1000m,
                            Stock = 80,
                            SubCategoryId = 4
                        },
                        new
                        {
                            Id = 11,
                            Name = "SINBO TARTI",
                            Price = 250m,
                            Stock = 70,
                            SubCategoryId = 5
                        },
                        new
                        {
                            Id = 12,
                            Name = "KIWI AIRFRYER",
                            Price = 4500m,
                            Stock = 50,
                            SubCategoryId = 6
                        },
                        new
                        {
                            Id = 13,
                            Name = "IPHONE 15",
                            Price = 55000m,
                            Stock = 100,
                            SubCategoryId = 7
                        },
                        new
                        {
                            Id = 14,
                            Name = "IPHONE 14 ",
                            Price = 42000m,
                            Stock = 80,
                            SubCategoryId = 7
                        },
                        new
                        {
                            Id = 15,
                            Name = "SAMSUNG S23",
                            Price = 28000m,
                            Stock = 70,
                            SubCategoryId = 8
                        },
                        new
                        {
                            Id = 16,
                            Name = "SAMSUNG FE",
                            Price = 17000m,
                            Stock = 50,
                            SubCategoryId = 8
                        });
                });

            modelBuilder.Entity("Core.Models.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Products Features", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Beyaz",
                            Description = "Insta View",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Color = "Gri",
                            Description = "No Frost",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            Color = "Beyaz",
                            Description = "No Frost",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            Color = "Gri",
                            Description = "No Frost",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            Color = "Beyaz",
                            Description = "i5 8/512 Gb",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            Color = "Siyah",
                            Description = "Matebook D15",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            Color = "Beyaz",
                            Description = "Macbook Air 13",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            Color = "Gri",
                            Description = "Tuf Gaming",
                            ProductId = 8
                        },
                        new
                        {
                            Id = 9,
                            Color = "Beyaz",
                            Description = "1.5 L",
                            ProductId = 9
                        },
                        new
                        {
                            Id = 10,
                            Color = "Beyaz",
                            Description = "1700 Watt",
                            ProductId = 10
                        },
                        new
                        {
                            Id = 11,
                            Color = "Beyaz",
                            Description = "Dijital",
                            ProductId = 11
                        },
                        new
                        {
                            Id = 12,
                            Color = "Beyaz",
                            Description = "11 L",
                            ProductId = 12
                        },
                        new
                        {
                            Id = 13,
                            Color = "Beyaz",
                            Description = "512 GB",
                            ProductId = 13
                        },
                        new
                        {
                            Id = 14,
                            Color = "Siyah",
                            Description = "128 GB",
                            ProductId = 14
                        },
                        new
                        {
                            Id = 15,
                            Color = "Beyaz",
                            Description = "128 GB",
                            ProductId = 15
                        },
                        new
                        {
                            Id = 16,
                            Color = "Mavi",
                            Description = "128 GB",
                            ProductId = 16
                        });
                });

            modelBuilder.Entity("Core.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sub Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            SubCategoryName = "Buzdolabı"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            SubCategoryName = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            SubCategoryName = "Kettle"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            SubCategoryName = "Blender"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            SubCategoryName = "Tartı"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            SubCategoryName = "Airfryer"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 4,
                            SubCategoryName = "IOS Telefonlar"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            SubCategoryName = "Samsung Telefonlar"
                        });
                });

            modelBuilder.Entity("Core.Models.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CartId")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<bool>("IsGuest")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLoggedIn")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CartId")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("CartProduct", b =>
                {
                    b.HasOne("Core.Models.Cart", null)
                        .WithMany()
                        .HasForeignKey("CartsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Models.Category", b =>
                {
                    b.HasOne("Core.Models.ParentCategory", "ParentCategory")
                        .WithMany("Categories")
                        .HasForeignKey("ParentCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("Core.Models.Product", b =>
                {
                    b.HasOne("Core.Models.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("Core.Models.ProductFeature", b =>
                {
                    b.HasOne("Core.Models.Product", "Product")
                        .WithOne("ProductFeature")
                        .HasForeignKey("Core.Models.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Models.SubCategory", b =>
                {
                    b.HasOne("Core.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Core.Models.UserAccount", b =>
                {
                    b.HasOne("Core.Models.Cart", "Cart")
                        .WithOne("UserAccount")
                        .HasForeignKey("Core.Models.UserAccount", "CartId");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Core.Models.Cart", b =>
                {
                    b.Navigation("UserAccount");
                });

            modelBuilder.Entity("Core.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Core.Models.ParentCategory", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Core.Models.Product", b =>
                {
                    b.Navigation("ProductFeature");
                });

            modelBuilder.Entity("Core.Models.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
