﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCustomComputers.Data;

#nullable disable

namespace MyCustomComputers.Migrations
{
    [DbContext(typeof(MyCustomComputersContext))]
    partial class MyCustomComputersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyCustomComputers.Models.Invoice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Addres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("MyCustomComputers.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Addres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InvoiceID")
                        .HasColumnType("int");

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<int?>("ReturnID")
                        .HasColumnType("int");

                    b.Property<int>("ShippingFee")
                        .HasColumnType("int");

                    b.Property<string>("ShippingMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("VAT")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("ProductID");

                    b.HasIndex("ReturnID");

                    b.HasIndex("UserID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("MyCustomComputers.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Graphics")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HardDisc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("MyCustomComputers.Models.Return", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Return");
                });

            modelBuilder.Entity("MyCustomComputers.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MyCustomComputers.Models.Order", b =>
                {
                    b.HasOne("MyCustomComputers.Models.Invoice", "Invoice")
                        .WithMany("Orders")
                        .HasForeignKey("InvoiceID");

                    b.HasOne("MyCustomComputers.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductID");

                    b.HasOne("MyCustomComputers.Models.Return", "Return")
                        .WithMany("Orders")
                        .HasForeignKey("ReturnID");

                    b.HasOne("MyCustomComputers.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID");

                    b.Navigation("Invoice");

                    b.Navigation("Product");

                    b.Navigation("Return");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyCustomComputers.Models.Return", b =>
                {
                    b.HasOne("MyCustomComputers.Models.User", "User")
                        .WithMany("Returns")
                        .HasForeignKey("UserID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyCustomComputers.Models.Invoice", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MyCustomComputers.Models.Product", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MyCustomComputers.Models.Return", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MyCustomComputers.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Returns");
                });
#pragma warning restore 612, 618
        }
    }
}
